﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class InspectionParametrs
    {

        /// <summary>
        /// перегрузка string
        /// проверка входного значния, если все хорошо то выходит значение double, иначе выводим окно с ошибка
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="editDesc"></param>
        /// <returns></returns>
        public static double Parametr(string edit, string editDesc)
        {
            double doubleEdit = 0;
            try
            {
                doubleEdit = Convert.ToDouble(edit);
            }
            catch (Exception)
            {
                // throw new CellFormatException(editDesc);
            }

            /*    if (doubleEdit <= 0)
                {
                    throw new CellOutOfRangeExxeption(editDesc);
                }*/
            return doubleEdit;
        }
    }
}

