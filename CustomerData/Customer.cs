using System;
using System.IO;

namespace CustomerData
{
    [Serializable]
    public class Customer
    {
        public readonly int AccountNo;
        public readonly string CustomerName;
        public readonly char CustomerType;
        public readonly double ChargeAmount;
        const string path = "numbers.txt";

        public Customer(int Account, string Name, char Type, double Charge)
        {
            AccountNo = Account;
            CustomerName = Name;
            CustomerType = Type;
            ChargeAmount = Charge;
        }

        public char Type()
        {
            return CustomerType;
        }

        public override string ToString()
        {
            return CustomerName;
        }

        public static void WriteData(double[] data, int count)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // open the file for writing; overwrite old content
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write data
                for (int i = 0; i < count; i++)
                    sw.WriteLine(data[i].ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error while writing to the file: " +
                   // ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close(); // also closes fs
            }
        }

        // reads data from the file and puts in an array
        // returns number of elemenst
        public static int ReadData(double[] data)
        {
            int count = 0; // counts numbers as it reads
            FileStream fs = null;
            StreamReader sr = null;
            string line; // for reading
            double num; // for reading
            // open the file for reading and read number into data
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream) // while there is data in the file
                {
                    line = sr.ReadLine(); // read the next line
                    num = Convert.ToDouble(line);
                    data[count] = num;
                    count++;
                }
            }
            catch (FormatException)
            {
                //MessageBox.Show("File contains non-numeric data. Aborting reading");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error while reading the file: "
                    //+ ex.Message, ex.GetType().ToString());
            }
            finally
            {
                // close the file if open
                if (sr != null) sr.Close(); //file stream gets closed too
            }
            return count;
        }
    }


}

