#include <avr/io.h>
#include <avr/interrupt.h>
#include <avr/pgmspace.h>
#include <avr/wdt.h>

#include "usbdrv.h"
#include "oddebug.h"
#include "common.h"

#include <global.h>		// globals from the AVRlib library
#include <servo.h>              // include RC servo driver library
#include <servoconf.h>
#include <rprintf.h>
#include <timer.h>


#define EEPROM_LOCATION 32
#define SERVO_START 127

static int servoPositions[MAX_SERVOS];
static unsigned char switchPositions;

/*
static void eepromWrite(unsigned char addr, unsigned char val)
{
	while(EECR & (1 << EEWE));
	EEARL = addr;
	EEDR = val;
	cli();
	EECR |= 1 << EEMWE;
	EECR |= 1 << EEWE;
	sei();
}

static uchar    eepromRead(uchar addr)
{
	while(EECR & (1 << EEWE));
	EEARL = addr;
	EECR |= 1 << EERE;
	return EEDR;
}
*/

void setSwitch(uchar sw, uchar onoff){
	switch(onoff){
		case 0:
			switchPositions &= ~(0x01 << sw);
			break;
		case 1:
			switchPositions |= (0x01 << sw);
			break;
	}

	switch(sw){
		case 0:
			if(onoff == 1){
				PORTC |= _BV(PC2);
			} else {
				PORTC &= ~_BV(PC2);
			}
			break;
		case 1:
			if(onoff == 1){
				PORTC |= _BV(PC3);
			} else {
				PORTC &= ~_BV(PC3);
			}
			break;
		case 2:
			if(onoff == 1){
				PORTC |= _BV(PC4);
			} else {
				PORTC &= ~_BV(PC4);
			}
			break;
		case 3:
			if(onoff == 1){
				PORTC |= _BV(PC5);
			} else {
				PORTC &= ~_BV(PC5);
			}
			break;
		case 4:
			if(onoff == 1){
				PORTC |= _BV(PC6);
			} else {
				PORTC &= ~_BV(PC6);
			}
			break;
		case 5:
			if(onoff == 1){
				PORTD |= _BV(PD5);
			} else {
				PORTD &= ~_BV(PD5);
			}
			break;
		case 6:
			if(onoff == 1){
				PORTD |= _BV(PD6);
			} else {
				PORTD &= ~_BV(PD6);
			}
			break;
		case 7:
			if(onoff == 1){
				PORTD |= _BV(PD7);
			} else {
				PORTD &= ~_BV(PD7);
			}
			break;
	}
}

uchar   usbFunctionSetup(uchar data[8])
{
	static uchar replyBuf[8];

	usbMsgPtr = replyBuf;
	
	if(data[1] == USCMD_ECHO){
		replyBuf[0] = data[2];
		replyBuf[1] = data[3];
		return 2;
	}

	if(data[1] == USCMD_SERVOSTATUS){
		int i;
		for(i = 0; i < MAX_SERVOS; i++){
			replyBuf[i] = servoPositions[i];
		}
		return MAX_SERVOS;
	}

	if(data[1] == USCMD_SWITCHSTATUS){
		int i;
		for(i = 0; i < MAX_SERVOS; i++){
			if(switchPositions & (0x01 << i)){
				replyBuf[i] = 1;
			}else{
				replyBuf[i] = 0;
			}
		}

		return MAX_SWITCHES;
	}

	if(data[1] == USCMD_SETSERVO){
		if(data[2] <= MAX_SERVOS){
			servoSetPosition(data[2], data[4]);
			servoPositions[data[2]] = data[4];
		}
		return 0;
    }
    
    if(data[1] == USCMD_SETSWITCH){
        if(data[2] <= MAX_SWITCHES){
            setSwitch(data[2], data[4]);
        }
        return 0;
    }

	return 0;
}

/* allow some inter-device compatibility */
#if !defined TCCR0 && defined TCCR0B
#define TCCR0   TCCR0B
#endif
#if !defined TIFR && defined TIFR0
#define TIFR    TIFR0
#endif

int main(void)
{
	uchar   i, j;

	wdt_enable(WDTO_1S);
	odDebugInit();
	PORTD = 0x00;
	PORTB = 0x00;
	PORTC = 0x00;
	DDRB = 0xff;
	DDRC = 0xff;
	j = 0;
    
	while(--j){
		i = 0;
		while(--i);     /* delay >10ms for USB reset */
	}

	servoInit();
	servoSetChannelIO(0, _SFR_IO_ADDR(PORTB), PB0);
	servoSetChannelIO(1, _SFR_IO_ADDR(PORTB), PB1);
	servoSetChannelIO(2, _SFR_IO_ADDR(PORTB), PB2);
	servoSetChannelIO(3, _SFR_IO_ADDR(PORTB), PB3);
    servoSetChannelIO(4, _SFR_IO_ADDR(PORTB), PB4);
    servoSetChannelIO(5, _SFR_IO_ADDR(PORTB), PB5);
	servoSetChannelIO(6, _SFR_IO_ADDR(PORTC), PC0);
    servoSetChannelIO(7, _SFR_IO_ADDR(PORTC), PC1);

	DDRD = ~USBMASK;    /* all outputs except USB data */
	for(i = 0; i < MAX_SERVOS; i++){
		servoSetPosition(i, SERVO_START);
		servoPositions[i] = SERVO_START;
	}
    
    switchPositions = 0x00;    

	usbInit();
	sei();
	for(;;){    /* main event loop */
		wdt_reset();
		usbPoll();
	}
	return 0;
}

