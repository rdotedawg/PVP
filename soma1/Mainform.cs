using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Input;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace soma1
{


    public partial class Mainform : Form

    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);



        int active = 0;
        public Mem m = new Mem();
        public Mainform()
        {
            InitializeComponent();
            int UniqueHotkeyId = 1;
            int HotKeyCode = (int)Keys.Insert;
            Boolean F9Registered = RegisterHotKey(
                this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode);

        }

        protected override void WndProc(ref Message m)
        {
            // 5. Catch when a HotKey is pressed !
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == 1)
                {
                    if (active == 0)
                    {
                        active = 1;
                        botactive.Invoke(new Action(() => botactive.Text = "ACTIVE"));
                        botactive.Invoke(new Action(() => botactive.ForeColor = Color.Green));
                        if (BGworker.IsBusy)
                        {

                        } else
                            {
                            BGworker.RunWorkerAsync();
                        }
                    }
                    else
                    {
                        active = 0;
                        botactive.Invoke(new Action(() => botactive.Text = "NOT ACTIVE"));
                        botactive.Invoke(new Action(() => botactive.ForeColor = Color.Red));
                        hook.Invoke(new Action(() => hook.Text = "N/A"));
                        charname.Invoke(new Action(() => charname.Text = "N/A"));
                        if (BGworker.IsBusy == true && BGworker.WorkerSupportsCancellation == true)
                        {
                            BGworker.CancelAsync();
                        }
                    }
                }
            }

            base.WndProc(ref m);
        }

        int speed = 0;
        int syrumspeed1 = 0;

        private void BGworker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (active == 1)
            {

                while (active == 1)
                {
                    if (m.OpenProcess("SomaWindow.exe"))                //Check for Hook
                    {





                        hook.Invoke(new Action(() => hook.Text = "Process found"));

                        charname.Invoke(new Action(() => charname.Text = m.ReadString("base+0x2D8600, 58, 0")));        //Check character name
                        Invoke(new Action(() => speed = botspeed.SelectedIndex));
                        Invoke(new Action(() => syrumspeed1 = syrumspeed.SelectedIndex));

                        switch (speed) //Set speed for bot
                        {
                            case 0:
                                speed = 10;
                                break;
                            case 1:
                                speed = 100;
                                break;
                            case 2:
                                speed = 400;
                                break;
                            case 3:
                                speed = 900;
                                break;
                            case 4:
                                speed = 1500;
                                break;
                            case 5:
                                Random random = new Random();
                                int num = random.Next(200, 1500);
                                speed = num;

                                break;
                        }

                        switch (syrumspeed1) //Set extra delay for syrums
                        {
                            case 0:
                                syrumspeed1 = 10;
                                break;
                            case 1:
                                syrumspeed1 = 100;
                                break;
                            case 2:
                                syrumspeed1 = 400;
                                break;
                            case 3:
                                syrumspeed1 = 900;
                                break;
                            case 4:
                                syrumspeed1 = 1500;
                                break;
                            case 5:
                                Random random = new Random();
                                int num = random.Next(200, 1500);
                                speed = num;

                                break;
                        }


                        System.Threading.Thread.Sleep(100);


                        if (autosyrum.Checked)
                        {
                            this.RunAutoSyrum();
                        }

                        if (autohealth.Checked)
                        {
                            this.AutoHeal();
                        }

                        if (automp.Checked)
                        {
                            this.AutoMP();
                        }



                    }
                    else // Update UI when not hooked
                    {
                        hook.Invoke(new Action(() => hook.Text = "N/A"));
                        charname.Invoke(new Action(() => charname.Text = "N/A"));
                    }
                }
            }

        }
        private void Mainform_Shown(object sender, EventArgs e)
        {
            //BGworker.RunWorkerAsync();
 
        }

        string ForestF;
        string HeavenF;
        string DemonF;

        public void RunAutoSyrum()
        {

            int BeltPosition = 0x11CE;
            int BeltItemCount = 0x11e6;


            //Check if spell animation is on player 
            if (m.ReadInt("base+2D8600, DC") != 0)
            {

                //Find Forest Water
                int BeltPosition1 = BeltPosition;
                int BeltItemCount1 = BeltItemCount;

                for (int i = 1; i < 5; i++)
                {
                    string amount = BeltItemCount1.ToString("X");
                    string position = BeltPosition1.ToString("X");
                    int amount1 = (m.ReadInt("base+2D8600, " + amount));
                    if (amount1 > 65536)
                        switch (m.ReadInt("base+2D8600, " + position))
                        {
                            case 0x014D:                                 // Forest Water HUMAN
                                switch (position)
                                {
                                    case "11CE":
                                        ForestF = "{F1}";
                                        break;

                                    case "121A":
                                        ForestF = "{F2}";
                                        break;

                                    case "1266":
                                        ForestF = "{F3}";
                                        break;

                                    case "12B2":
                                        ForestF = "{F4}";
                                        break;
                                }
                                break;
                        }
                    BeltPosition1 += 0x4c;
                    BeltItemCount1 += 0x4c;
                }

                //Find Demon
                BeltPosition1 = BeltPosition;
                BeltItemCount1 = BeltItemCount;

                for (int i = 1; i < 5; i++)
                {
                    string amount = BeltItemCount1.ToString("X");
                    string position = BeltPosition1.ToString("X");
                    int amount1 = (m.ReadInt("base+2D8600, " + amount));
                    if (amount1 > 65536)
                        switch (m.ReadInt("base+2D8600, " + position))
                        {
                            case 0x014B:                                 // Demon Water
                                switch (position)
                                {
                                    case "11CE":
                                        DemonF = "{F1}";
                                        break;

                                    case "121A":
                                        DemonF = "{F2}";
                                        break;

                                    case "1266":
                                        DemonF = "{F3}";
                                        break;

                                    case "12B2":
                                        DemonF = "{F4}";
                                        break;
                                }
                                break;
                        }
                    BeltPosition1 += 0x4c;
                    BeltItemCount1 += 0x4c;
                }


                //Find Heaven
                BeltPosition1 = BeltPosition;
                BeltItemCount1 = BeltItemCount;

                for (int i = 1; i < 5; i++)
                {
                    string amount = BeltItemCount1.ToString("X");
                    string position = BeltPosition1.ToString("X");
                    int amount1 = (m.ReadInt("base+2D8600, " + amount));
                    if (amount1 > 65536)
                        switch (m.ReadInt("base+2D8600, " + position))
                        {
                            case 0x014C:                                 // Heaven Water
                                switch (position)
                                {
                                    case "11CE":
                                        HeavenF = "{F1}";
                                        break;

                                    case "121A":
                                        HeavenF = "{F2}";
                                        break;

                                    case "1266":
                                        HeavenF = "{F3}";
                                        break;

                                    case "12B2":
                                        HeavenF = "{F4}";
                                        break;
                                }
                                break;
                        }
                    BeltPosition1 += 0x4c;
                    BeltItemCount1 += 0x4c;
                }

            }



            //Check if status != 0
            if (m.ReadInt("base+2D8600, DC") != 0)
            {

                if (autoweaken.Checked) //Check for weaken 
                {
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "63");
                    string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                    Thread.Sleep(10);
                    string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");
 
                    if (SpellActive == "1" && Spell == "3F")
                    {
                        if (ForestF != null)
                        {
                            Thread.Sleep(syrumspeed1);
                            SendKeys.SendWait(ForestF);
                            Invoke(new Action(() => weaknum.Text = (int.Parse(weaknum.Text) + 1).ToString()));
                            ForestF = null;
                        }
                    }

                }



                if (autoslow.Checked) //Check for slow
                {
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "57");
                    string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                    Thread.Sleep(10);
                    string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");

                    if (SpellActive == "1" && Spell == "39")
                    {
                        if (HeavenF != null)
                        {
                            Thread.Sleep(syrumspeed1);
                            SendKeys.SendWait(HeavenF);
                            Invoke(new Action(() => slownum.Text = (int.Parse(slownum.Text) + 1).ToString()));
                            HeavenF = null;
                        }
                    }
                }

                if (autoconfuse.Checked) //Check for Confuse
                {
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "68");
                    string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                    Thread.Sleep(10);
                    string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");

                    if (SpellActive == "1" && Spell == "44")
                    {
                        if (DemonF != null)
                        {
                            Thread.Sleep(syrumspeed1);
                            SendKeys.SendWait(DemonF);
                            Invoke(new Action(() => confusenum.Text = (int.Parse(confusenum.Text) + 1).ToString()));
                            DemonF = null;
                        }
                    }
                }

                if (autoblind.Checked) //Check for Blind
                {
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "61");
                    string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                    Thread.Sleep(10);
                    string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");

                    if (SpellActive == "1" && Spell == "3D")
                    {
                        if (DemonF != null)
                        {
                            Thread.Sleep(syrumspeed1);
                            SendKeys.SendWait(DemonF);
                            Invoke(new Action(() => blindnum.Text = (int.Parse(blindnum.Text) + 1).ToString()));
                            DemonF = null;
                        }
                    }
                }

                if (autozombie.Checked) //Check for Zombie
                {
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "51");
                    string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                    Thread.Sleep(10);
                    string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");

                    if (SpellActive == "1" && Spell == "33")
                    {
                        if (DemonF != null)
                        {
                            Thread.Sleep(syrumspeed1);
                            SendKeys.SendWait(DemonF);
                            Invoke(new Action(() => zombienum.Text = (int.Parse(zombienum.Text) + 1).ToString()));
                            DemonF = null;
                        }
                    }
                }

                if (autozombie.Checked) //Check for Giggle
                {
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                    m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "65");
                    string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                    Thread.Sleep(10);
                    string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");

                    if (SpellActive == "1" && Spell == "41")
                    {
                        if (HeavenF != null)
                        {
                            Thread.Sleep(syrumspeed1);
                            SendKeys.SendWait(HeavenF);
                            Invoke(new Action(() => gigglenum.Text = (int.Parse(gigglenum.Text) + 1).ToString()));
                            HeavenF = null;
                        }
                    }
                }

            }
            }

        public void AutoHeal()
        {

            int HealthPercent = 0;//Work out if HP is below set Value
            Invoke(new Action(() => HealthPercent = healthslider.Value));
            int MaxHealth = (m.ReadInt("base+2D8600, 244"));
            int CurrHealth = (m.ReadInt("base+2D8600, 240"));
            if (CurrHealth <= MaxHealth / 100 * HealthPercent)
            {
                string HPFKey = null;
                int BeltPosition = 0x11CE;
                int BeltItemCount = 0x11e6;
                int BeltPosition1 = BeltPosition;
                int BeltItemCount1 = BeltItemCount;


                for (int i = 1; i < 5; i++)
                {
                    string amount = BeltItemCount1.ToString("X");
                    string position = BeltPosition1.ToString("X");
                    int amount1 = (m.ReadInt("base+2D8600, " + amount));
                    if (amount1 > 0) //65536
                        switch (m.ReadInt("base+2D8600, " + position))
                        {
                            case 0x0156:                                 // 50/100/150 HP
                                switch (position)
                                {
                                    case "11CE":
                                        HPFKey = "{F1}";
                                        break;

                                    case "121A":
                                        HPFKey = "{F2}";
                                        break;

                                    case "1266":
                                        HPFKey = "{F3}";
                                        break;

                                    case "12B2":
                                        HPFKey = "{F4}";
                                        break;
                                }
                                break;
                            case 0x00E1:                                 // 10 HP
                                switch (position)
                                {
                                    case "11CE":
                                        HPFKey = "{F1}";
                                        break;

                                    case "121A":
                                        HPFKey = "{F2}";
                                        break;

                                    case "1266":
                                        HPFKey = "{F3}";
                                        break;

                                    case "12B2":
                                        HPFKey = "{F4}";
                                        break;
                                }
                                break;
                            case 0x0158:                                 // 20 HP
                                switch (position)
                                {
                                    case "11CE":
                                        HPFKey = "{F1}";
                                        break;

                                    case "121A":
                                        HPFKey = "{F2}";
                                        break;

                                    case "1266":
                                        HPFKey = "{F3}";
                                        break;

                                    case "12B2":
                                        HPFKey = "{F4}";
                                        break;
                                }
                                break;
                            case 0x0030:                                 // 25 HP
                                switch (position)
                                {
                                    case "11CE":
                                        HPFKey = "{F1}";
                                        break;

                                    case "121A":
                                        HPFKey = "{F2}";
                                        break;

                                    case "1266":
                                        HPFKey = "{F3}";
                                        break;

                                    case "12B2":
                                        HPFKey = "{F4}";
                                        break;
                                }
                                break;


                        }

                    BeltPosition1 += 0x4c;
                    BeltItemCount1 += 0x4c;
                }

                if (HPFKey != null)
                {
                    //Check if spell animation is on player to check for zombie before using hp
                    if (m.ReadInt("base+2D8600, DC") != 0)
                    {
                        m.WriteMemory("base+002D8600, 134 , 20, 0, 14", "int", "0");
                        m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "51");
                        string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
                        Thread.Sleep(10);
                        string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");

                        if (SpellActive == "1" && Spell == "33")
                        {
                            Console.Beep();
                            return;
                        }
                          
                    }
                    Thread.Sleep(speed);
                    SendKeys.SendWait(HPFKey); //Send F key for HP
                    Invoke(new Action(() => healthnum.Text = (int.Parse(healthnum.Text) + 1).ToString()));


                }
            } 
        }

        public void AutoMP()
        {
            int MPPercent = 0;//Work out if MP is below set Value
            Invoke(new Action(() => MPPercent = mpslider.Value));
            int MaxMP = (m.ReadInt("base+2D8600, 24c"));
            int CurrMP = (m.ReadInt("base+2D8600, 248"));
            if (CurrMP <= MaxMP / 100 * MPPercent)
            {
                string MPFKey = null;
                int BeltPosition = 0x11CE;
                int BeltItemCount = 0x11e6;
                int BeltPosition1 = BeltPosition;
                int BeltItemCount1 = BeltItemCount;


                for (int i = 1; i < 5; i++)
                {
                    string amount = BeltItemCount1.ToString("X");
                    string position = BeltPosition1.ToString("X");
                    int amount1 = (m.ReadInt("base+2D8600, " + amount));
                    if (amount1 > 0 )
                        switch (m.ReadInt("base+2D8600, " + position))
                    {
                        case 0x0157:                                 // 50/100/150 MP
                            switch (position)
                            {
                                case "11CE":
                                    MPFKey = "{F1}";
                                    break;

                                case "121A":
                                    MPFKey = "{F2}";
                                    break;

                                case "1266":
                                    MPFKey = "{F3}";
                                    break;

                                case "12B2":
                                    MPFKey = "{F4}";
                                    break;
                            }
                            break;
                        case 0x00E2:                                 // 10 MP
                            switch (position)
                            {
                                case "11CE":
                                    MPFKey = "{F1}";
                                    break;

                                case "121A":
                                    MPFKey = "{F2}";
                                    break;

                                case "1266":
                                    MPFKey = "{F3}";
                                    break;

                                case "12B2":
                                    MPFKey = "{F4}";
                                    break;
                            }
                            break;
                        case 0x0159:                                 // 20 MP
                            switch (position)
                            {
                                case "11CE":
                                    MPFKey = "{F1}";
                                    break;

                                case "121A":
                                    MPFKey = "{F2}";
                                    break;

                                case "1266":
                                    MPFKey = "{F3}";
                                    break;

                                case "12B2":
                                    MPFKey = "{F4}";
                                    break;
                            }
                            break;
                        case 0x0031:                                 // 25 MP
                            switch (position)
                            {
                                case "11CE":
                                    MPFKey = "{F1}";
                                    break;

                                case "121A":
                                    MPFKey = "{F2}";
                                    break;

                                case "1266":
                                    MPFKey = "{F3}";
                                    break;

                                case "12B2":
                                    MPFKey = "{F4}";
                                    break;
                            }
                            break;


                    }

                    BeltPosition1 += 0x4c;
                    BeltItemCount1 += 0x4c;
                }

                if (MPFKey != null)
                {
                    SendKeys.SendWait(MPFKey); //Send F key for MP
                    Invoke(new Action(() => mpnum.Text = (int.Parse(mpnum.Text) + 1).ToString()));
                }
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            m.WriteMemory("base+002D8600, 134 , 20, 0, 0", "int", "63");
            string SpellActive = m.ReadByte("base+002D8600, 134 , 20, 0, 14").ToString("X");
            string Spell = m.ReadByte("base+002D8600, 134, 20, 0, 0").ToString("X");
            MessageBox.Show(SpellActive);
            MessageBox.Show(Spell);
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            AdminRelauncher.RelaunchIfNotAdmin();
            botspeed.Invoke(new Action(() => botspeed.SelectedIndex = 1));
            syrumspeed.Invoke(new Action(() => syrumspeed.SelectedIndex = 5));

        }

        private void Mainform_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Shown");
        }

        private void healthslider_ValueChanged(object sender, EventArgs e)
        {
            healat.Text = "Use potion at " + healthslider.Value + "% HP";
        }

        private void mpslider_ValueChanged(object sender, EventArgs e)
        {
            mpat.Text = "Use potion at " + mpslider.Value  + "% MP";
        }

        private void Mainform_Activated(object sender, EventArgs e)
        {
            if (active == 1)
            {

                active = 0;
                botactive.Invoke(new Action(() => botactive.Text = "NOT ACTIVE"));
                botactive.Invoke(new Action(() => botactive.ForeColor = Color.Red));
                hook.Invoke(new Action(() => hook.Text = "N/A"));
                charname.Invoke(new Action(() => charname.Text = "N/A"));
                if (BGworker.IsBusy == true && BGworker.WorkerSupportsCancellation == true)
                {
                    BGworker.CancelAsync();
                }
            }
        }


    }
    public static class AdminRelauncher
    {
        public static void RelaunchIfNotAdmin()
        {
            if (!RunningAsAdmin())
            {
                Console.WriteLine("Running as admin required!");
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Assembly.GetEntryAssembly().CodeBase;
                proc.Verb = "runas";
                try
                {
                    Process.Start(proc);
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("This program must be run as an administrator! \n\n" + ex.ToString());
                    Environment.Exit(0);
                }
            }
        }

        private static bool RunningAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }

}
