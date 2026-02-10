using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    internal class Week
    {
        static readonly string[] DayNames = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        byte days;
        public Week(byte days)
        {
            this.days = days;
        }
        public override string ToString()
        {
            string learningDays = "";
            for(int i =0; i < DayNames.Length; i++)
            {
                learningDays += (days & (1 << i )) == 0 ? "" : $"{DayNames[i]}, ";
                //if ((days & (1 << i)) != 0) 
            }
            return learningDays;
        }

        public static byte FromToStringLearningDays(CheckedListBox checkedListBox)
        {
            byte learning_days = 0;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                    learning_days += (byte)(1 << i);

            }
            return learning_days;
        }
    }
}
