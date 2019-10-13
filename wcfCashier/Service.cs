using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcfCashier
{
    public class Service
    {
        public void Kalkulasi(string jlh, string hrg)
        {
            try
            {
                if (Convert.ToInt32(jlh) > 50)
                {
                    MessageBox.Show("Salah boy");
                }
                int x = Convert.ToInt32(hrg);
                int jumlah = Convert.ToInt32(jlh);
                int total = x * jumlah;
                string ttl = "Rp " + Convert.ToString(total);
            }
            catch
            {

            }
        }
    }
}
