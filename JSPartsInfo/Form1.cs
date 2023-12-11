using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace JSPartsInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            this.ddl_Language.SelectedIndex = 0;
        }

        #region "erneuern..."-Button
        //Button "Info auslesen" -> Die Werte werden in die Textboxen geladen

        private void btn_InfosAuslesen_Click(object sender, EventArgs e)
        {
            txb_BoardID.Text = null;
            txb_BIOS.Text = null;
            txb_BIOSCap.Text = null;
            txb_BIOSSN.Text = null;
            txb_CPU.Text = null;
            txb_CPUSpeed.Text = null;
            txb_HDD.Text = null;
            txb_Mainboard.Text = null;
            txb_RAM.Text = null;
            txb_RAMSlots.Text = null;
            txb_Mainboard.Text = null;

            txb_BoardID.Text = GetBoardProductId();
            txb_BIOS.Text = GetBIOSmaker();
            txb_BIOSCap.Text = GetBIOScaption();
            txb_BIOSSN.Text = GetBIOSserNo();
            txb_CPU.Text = GetProcessorInformation();
            txb_CPUSpeed.Text = GetCpuSpeedInGHz().ToString() + " GHz";
            txb_HDD.Text = GetHDDSerialNo();
            txb_Mainboard.Text = GetBoardMaker();
            txb_RAM.Text = GetPhysicalMemory();
            txb_RAMSlots.Text = GetNoRamSlots();
            txb_Mainboard.Text = GetBoardMaker();
        }
        #endregion

        public static String GetProcessorId()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;

        }

        public static String GetHDDSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        public static string GetBoardMaker()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }

                catch { }

            }

            return "Board Maker: Unknown";

        }

        public static string GetBoardProductId()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Product").ToString();

                }

                catch { }

            }

            return "Product: Unknown";

        }

        public static string GetBIOSmaker()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();

                }

                catch { }

            }

            return "BIOS Maker: Unknown";

        }
        /// <summary>
        /// Retrieving BIOS Serial No.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSserNo()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SerialNumber").ToString();

                }

                catch { }

            }

            return "BIOS Serial Number: Unknown";

        }
        /// <summary>
        /// Retrieving BIOS Caption.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOScaption()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Caption").ToString();

                }
                catch { }
            }
            return "BIOS Caption: Unknown";
        }

        public static string GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + "MB";
        }

        public static string GetNoRamSlots()
        {

            int MemSlots = 0;
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            foreach (ManagementObject obj in oCollection2)
            {
                MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

            }
            return MemSlots.ToString();
        }

        public static string GetCPUManufacturer()
        {
            string cpuMan = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuMan == String.Empty)
                {
                    // only return manufacturer from first CPU
                    cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                }
            }
            return cpuMan;
        }
       
       
        public static double? GetCpuSpeedInGHz()
        {
            double? GHz = null;
            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    GHz = 0.001 * (UInt32)mo.Properties["CurrentClockSpeed"].Value;
                    break;
                }
            }
            return GHz;
        }
        
        public static String GetProcessorInformation()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                string name = (string)mo["Name"];
                name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

                info = name; //+ ", " + (string)mo["Caption"]; // + ", " + (string)mo["SocketDesignation"];
                //mo.Properties["Name"].Value.ToString();
                //break;
            }
            return info;
        }
        #region Kopier-Buttons
        //Buttons "Kopieren" -> Textboxwert wird in den Zwischenspeicher kopiert

        private void pbx_Board_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_Mainboard.Text, true);
        }

        private void pbx_BoardID_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_BoardID.Text, true);
        }

        private void pxb_CPU_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_CPU.Text, true);
        }

        private void pxb_CPUSpeed_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_CPUSpeed.Text, true);
        }

        private void pbx_RAM_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_RAM.Text, true);
        }

        private void pbx_RAMSlots_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_RAMSlots.Text, true);
        }

        private void pbx_HDD_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_HDD.Text, true);
        }

        private void pbx_BIOS_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_BIOS.Text, true);
        }

        private void pbx_BIOSSN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_BIOSSN.Text, true);
        }

        private void pbx_BIOSCap_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_BIOSCap.Text, true);
        }

        private void pbx_CopyAll_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_Mainboard.Text + "\r\n" + txb_BoardID.Text + "\r\n" + txb_CPU.Text + "\r\n" + txb_CPUSpeed.Text + "\r\n" + txb_RAM.Text + "\r\n" + txb_RAMSlots.Text + "\r\n" + txb_HDD.Text + "\r\n" + txb_BIOS.Text + "\r\n" + txb_BIOSSN.Text + "\r\n" + txb_BIOSCap.Text, true);
        }
        #endregion

        #region Sprachauswahl
        // Umstellen der Sprache auf den zwei Flaggen-Buttons

        private void ddl_Language_Changed(object sender, EventArgs e)
        {

            if (ddl_Language.Text == "English")
            {
                lbl_BIOS.Text = "BIOS:";
                lbl_BIOSCap.Text = "BIOS version:";
                lbl_BIOSSN.Text = "BIOS S/N:";
                lbl_Board.Text = "Board:";
                lbl_BoardID.Text = "Board S/N:";
                lbl_CPU.Text = "CPU:";
                lbl_CPUSpeed.Text = "CPU speed:";
                lbl_HDD.Text = "Hard drive S/N:";
                lbl_RAM.Text = "RAM:";
                lbl_RAMSlots.Text = "Slots:";

                btn_InfosAuslesen.Text = "refresh...";
            }
            else
            {
                lbl_BIOS.Text = "BIOS-Hersteller:";
                lbl_BIOSCap.Text = "BIOS-Version:";
                lbl_BIOSSN.Text = "BIOS-S/N:";
                lbl_Board.Text = "Board:";
                lbl_BoardID.Text = "Board-S/N:";
                lbl_CPU.Text = "CPU:";
                lbl_CPUSpeed.Text = "Taktung:";
                lbl_HDD.Text = "Festplatten-S/N:";
                lbl_RAM.Text = "RAM-Speicher:";
                lbl_RAMSlots.Text = "Anzahl Riegel:";
            }
        }
        #endregion

        #region Info-Button
        // Ruft ein zweites Form mit Programminformationen auf

        private void pbx_Info_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.Focus();
            this.Visible = false;
        }
        #endregion
    }
}     
