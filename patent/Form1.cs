using ClassLibraryRool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace patent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public  int number_of_clips_n;
        public double diameter_of_rollers_d, thickness_h, width_B,step_t, SigT_, modulus_of_elasticity_E,vi,Xi0;


        public double result,Xost,Aost,xost1;
        public double Lb_base_curvature_measurement = 3.0 / 1000.0;

        Dictionary<string, dataBd> keys = new Dictionary<string, dataBd>();
        Dictionary<int,int> index=new Dictionary<int,int>();
        List<int>values_h = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.SheetsInNewWorkbook = 1;
            ex.DisplayAlerts = false;
            ex.Workbooks.Open(@"C:\Users\maksi\Desktop\patent\patent\bin\Debug\bd.xlsx",
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name ="данные" ;

            for (int i = 2; i <= 4; i++)
            { dataBd dataobject = new dataBd();               
                for (int j = 2; j < 8; j++)
                {
                    dataobject.setParam(sheet.Cells[j, i].Value);
                }
                keys.Add(sheet.Cells[1, i].Value,dataobject);
            }
        }
        private void ResultT_Click(object sender, EventArgs e)
        {
            res.Visible = true;
            number_of_clips_n = Convert.ToInt32(numberT.Text);

            diameter_of_rollers_d = Convert.ToDouble(diameterT.Text);
            thickness_h = Convert.ToDouble(thicknessT.Text);
            width_B = Convert.ToDouble(widthT.Text);
            step_t = Convert.ToDouble(stepT.Text);
            SigT_ = Convert.ToDouble(value: SigTt.Text);
            modulus_of_elasticity_E = Convert.ToDouble(modulusT.Text);
            vi = Convert.ToDouble(viT.Text);
            Xi0 = Convert.ToDouble(XioT.Text);
            int hmin = Convert.ToInt32(Hmin.Text);
            int hmax = Convert.ToInt32(Hmax.Text);
            int Aostwrite = Convert.ToInt32(Aost_text.Text);
            bool iterator = true;
            if (Aost_text.Text != "" && Hmin.Text != "" && Hmax.Text != "")
            {
                for (int i = 0; i < keys["Толщина,мм"].datebasevalueStart.Count; i++)

                {
                    bool condition = hmin >= keys["Толщина,мм"].datebasevalueStart[i] && hmax <= keys["Толщина,мм"].datebasevalueEnd[i] && Aostwrite <= keys["Допуск плоскостности,мм/м"].datebasevalueStart[i];
                    if (condition && iterator && (Aostwrite <= 2 && 2 >= keys["Допуск плоскостности,мм/м"].datebasevalueStart[i]))
                    {
                        int deviation = keys["Толщина,мм"].datebasevalueEnd[i] - hmax;
                        index.Add(deviation, i);
                        values_h.Add(deviation);
                        iterator = false;
                    }
                    else if (condition && iterator && (Aostwrite > 2 && Aostwrite <= 8))
                    {
                        int deviation = keys["Толщина,мм"].datebasevalueEnd[i] - hmax;
                        index.Add(deviation, i);
                        values_h.Add(deviation);
                        iterator = false;
                    }
                    else if (condition && Aostwrite <= 3 && hmin != 8)
                    {
                        int deviation = keys["Толщина,мм"].datebasevalueEnd[i] - hmax;
                        index.Add(deviation, i);
                        values_h.Add(deviation);
                    }

                }
                res.Text += (keys["Толщина,мм"].datebasevalueStart[index[values_h.Min()]].ToString() + "\t");
                res.Text += (keys["Толщина,мм"].datebasevalueEnd[index[values_h.Min()]].ToString() + "\t");
                res.Text += (keys["Допуск плоскостности,мм/м"].datebasevalueStart[index[values_h.Min()]].ToString() + "\t");
                Gmax.Text = keys["Предел текучести,Мпа"].datebasevalueStart[index[values_h.Min()]].ToString();
            }
            else
            {
                for (int n = 5; n < 29; n+= 2)
                {
                    for (int d = 50; d < 360; d += 10)
                    {

                    }
                }
            }
                Pravka prav = new Pravka(number_of_clips_n, diameter_of_rollers_d, thickness_h, width_B, step_t, SigT_, modulus_of_elasticity_E, vi, Xi0);
                //MessageBox.Show(keys["Предел текучести,Мпа"].datebasevalueEnd[0].ToString());
                //messagebox.show(prav._aost.tostring());
                //messagebox.show(prav._pabs[3].tostring());
                //messagebox.show(prav._psum.tostring());
                //MessageBox.Show(prav._Xi0.ToString());
                //MessageBox.Show(prav._XiOst)
                //Xost = prav._XiOst;
                double a = Math.Round(Math.Pow(1.0 / Xost, 2), 15);
                double b = Math.Round(Math.Pow(Lb_base_curvature_measurement, 2) / 4, 15);
                Aost = (1.0 / Xost) - Math.Sqrt(Math.Abs(a - b));
                //не нужноо
                xost1 = 1 / (((1 * Aost) / 2) + (Math.Pow(Lb_base_curvature_measurement, 2)) / (8 * Aost));
                //MessageBox.Show((a-b).ToString());
                //MessageBox.Show((a).ToString());
                //MessageBox.Show((b).ToString());
                //MessageBox.Show(xost1.ToString());

            }
    }
}
