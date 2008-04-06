using System;
using System.Collections.Generic;
using System.Text;
using ICSharpCode.USBlib;

namespace usbServoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VENDOR_ID = 0x16C0;
            const int PRODUCT_ID = 0x05dc;

            const int SET_REQUESTTYPE = 0xC0;
            const int GET_REQUESTTYPE = 0xC0;

            const int USCMD_ECHO = 0;
            const int USCMD_SERVOSTATUS = 1;
            const int USCMD_SWITCHSTATUS = 2;
            const int USCMD_SETSERVO = 3;
            const int USCMD_SETSWITCH = 4;

            byte[] buffer = new byte[8];
            Device device = null;

            if (args.Length == 0)
            {
                usage();
                Environment.Exit(1);
            }

            foreach (Bus bus in Bus.Busses)
            {
                foreach (Descriptor descriptor in bus.Descriptors)
                {
                    if (descriptor.VendorId == VENDOR_ID &&
                        descriptor.ProductId == PRODUCT_ID)
                    {
                        device = descriptor.OpenDevice();
                    }
                }
            }

            if (device == null)
            {
                System.Console.Out.WriteLine("Device not found");
                Environment.Exit(1);
            }

            if (args[0] == "status")
            {
                System.Console.Out.WriteLine("");
                device.SendControlMessage(GET_REQUESTTYPE,
                                          USCMD_SERVOSTATUS,
                                          0,
                                          0,
                                          buffer
                                         );
                int i;
                for (i = 0; i < 8; i++)
                {
                    System.Console.Out.WriteLine("Servo  " + i + ": " + buffer[i]);
                }
                System.Console.Out.WriteLine("");
                device.SendControlMessage(GET_REQUESTTYPE,
                                          USCMD_SWITCHSTATUS,
                                          0,
                                          0,
                                          buffer
                                         );

                for (i = 0; i < 8; i++)
                {
                    System.Console.Out.WriteLine("Switch " + i + ": " + buffer[i]);
                }
            }
            else if (args[0] == "test")
            {
                int i, r, v;
                Random random = new Random();
                System.Console.Out.WriteLine("Sending random numbers...");
                for (i = 0; i < 1000; i++)
                {
                    v = random.Next() & 0xffff;
                    device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_ECHO,
                                          v,
                                          0,
                                          buffer
                                         );
                    if (buffer.Length < 2)
                    {
                        if (buffer.Length < 0)
                            System.Console.Out.WriteLine("USB error: ");
                        System.Console.Out.WriteLine("only " + buffer.Length + " bytes received in iteration " + i);
                        Environment.Exit(1);
                    }

                    r = buffer[0] | (buffer[1] << 8);

                    if (r != v)
                    {
                        System.Console.Out.WriteLine("data error: received " + r + " instead of " + v + " in iteration " + i);
                        Environment.Exit(1);
                    }
                }
                System.Console.Out.WriteLine("test succeeded");
            }
            else if ((args[0] == "set") && (args.Length == 3))
            {
                int servo = int.Parse(args[1]);
                int position = int.Parse(args[2]);

                System.Console.Out.WriteLine("Setting servo " + servo + " to " + position);

                device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_SETSERVO,
                                          servo,
                                          position,
                                          buffer
                                         );
            }
            else if ((args[0] == "switch") && (args.Length == 3))
            {
                int swnum = int.Parse(args[1]);
                int onoff = 0;
                if(String.Equals(args[2], "on")){
                    onoff = 1;
                }else if(String.Equals(args[2], "off")){
                    onoff = 0;
                }else{
                    usage();
                    Environment.Exit(1);
                }

                System.Console.Out.WriteLine("Turning switch " + swnum + " " + args[2]);

                device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_SETSWITCH,
                                          swnum,
                                          onoff,
                                          buffer
                                         );
            }
            else if((args[0] == "strobe") && (args.Length == 2)){
                int i;
                int millis = int.Parse(args[1]);
                for (i = 0; i < 8; i++)
                {
                    System.Console.WriteLine("Turning switch " + i + " off");
                    device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_SETSWITCH,
                                          i,
                                          0,
                                          buffer
                                         );
                    System.Threading.Thread.Sleep(millis);
                }
                System.Threading.Thread.Sleep(1000);
                for (i = 0; i < 8; i++)
                {
                    System.Console.WriteLine("Turning switch " + i + " on");
                    device.SendControlMessage(SET_REQUESTTYPE,
                                          USCMD_SETSWITCH,
                                          i,
                                          1,
                                          buffer
                                         );
                    System.Threading.Thread.Sleep(millis);
                }
            }
            else
            {
                usage();
            }
        }


        static void usage()
        {
            System.Console.Out.WriteLine("usage:");
            System.Console.Out.WriteLine("  usbServoConsole set <servo> <position>");
            System.Console.Out.WriteLine("  usbServoConsole status");
            System.Console.Out.WriteLine("  usbServoConsole test");
            System.Console.Out.WriteLine();
        }
    }
}
