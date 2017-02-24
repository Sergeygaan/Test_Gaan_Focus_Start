using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test_Gaan_Focus_Start
{
    class InsertionSort
    {
        private List<int> _intList = new List<int>();
        private string StringSave;
        private string StringSave1;
        private int SummCodesString;
        private int SummCodesString1;


        private int[] Summ1;
        private int[] Summ2;
        public List<String> Sorting(List<String> StringList, int IndexComboBox)
        {
            _intList.Clear();

            for (int i = 0; i < StringList.Count ; i++)
            {
                SummCodesString = 0;

                StringSave = StringList[i];
                for (int k = 0; k < StringSave.Length; k++)
                {
                    SummCodesString += (int)StringSave[k];
                }
                _intList.Add(SummCodesString);

            }

            for (int i = 0; i < _intList.Count; i++)
            {
                int cur = _intList[i];
               
                string SortStroka = StringList[i];

                int j = i;
                if (IndexComboBox == 0)
                {
                    int k = 0;
                    bool flag = true;
                    SummCodesString = 0;
                    SummCodesString1 = 0;
                    StringSave = " ";
                    StringSave1 = " ";

                    if ((j > 0) && (StringList[j].Length == StringList[j - 1].Length))
                    {

                        Summ1 = new int[StringList[j].Length];
                        Summ2 = new int[StringList[j - 1].Length];
                        while ((j > 0) && ((k < StringList[j].Length) && (k < StringList[j - 1].Length)))
                        {

                            StringSave = StringList[j];
                            Summ1[k] = (int)StringSave[k];


                            StringSave1 = StringList[j - 1];
                            Summ2[k] = (int)StringSave1[k];

                            k += 1;
                        }

                        int Col = 0;
                        for (int l = 0; l < Summ1.Length; l++)
                        {
                            if ((Summ1[l] < Summ2[l]) && (Col == l))
                            {
                                flag = false;
                                break;
                            }
                            else if (Summ1[l] == Summ2[l])
                            {
                                Col += 1;
                            }

                        }

                        if (j > 0 && flag == false)
                        {

                            StringList[j] = StringList[j - 1];
                            _intList[j] = _intList[j - 1];

                            flag = true;
                            j--;
                        }

                    }

                    else
                    {
                        while (j > 0 && cur < _intList[j - 1])
                        {
                            StringList[j] = StringList[j - 1];
                            _intList[j] = _intList[j - 1];
                            j--;
                        }
                    }

                }
                else
                {
                    int k = 0;
                    bool flag = true;
                    SummCodesString = 0;
                    SummCodesString1 = 0;
                    StringSave = " ";
                    StringSave1 = " ";

                    if ((j > 0) && (StringList[j].Length == StringList[j - 1].Length))
                    {

                        Summ1 = new int[StringList[j].Length];
                        Summ2 = new int[StringList[j - 1].Length];
                        while ((j > 0) && ((k < StringList[j].Length) && (k < StringList[j - 1].Length)))
                        {

                            StringSave = StringList[j];
                            Summ1[k] = (int)StringSave[k];


                            StringSave1 = StringList[j - 1];
                            Summ2[k] = (int)StringSave1[k];

                            k += 1;
                        }

                        int Col = 0;
                        for (int l = 0; l < Summ1.Length; l++)
                        {
                            if ((Summ1[l] > Summ2[l]) && (Col == l))
                            {
                                flag = false;
                                break;
                            }
                            else if (Summ1[l] == Summ2[l])
                            {
                                Col += 1;
                            }

                        }

                        if (j > 0 && flag == false)
                        {

                            StringList[j] = StringList[j - 1];
                            _intList[j] = _intList[j - 1];

                            flag = true;
                            j--;
                        }

                    }

                    else
                    {
                        while (j > 0 && cur > _intList[j - 1])
                        {
                            StringList[j] = StringList[j - 1];
                            _intList[j] = _intList[j - 1];
                            j--;
                        }
                    }
                }
                StringList[j] = SortStroka;
                _intList[j] = cur;
                
            }

            return StringList;
        }
    }
}
