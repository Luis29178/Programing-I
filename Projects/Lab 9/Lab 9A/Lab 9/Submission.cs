using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public static class Submission
    {
        public static Student Test1(string last, string first, int idNo)
        {
            Student X = new Student(last,first,idNo);
            return X;

        }

        public static Student Test2()
        {
            Student X = new Student();
            return X;
        }

        public static bool Test3(Student[] enrollment, Student enrolled)
        {
            bool ans = true;
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] == null)
                {                    
                    enrollment[i] = enrolled;
                    ans = true;
                    break;
                    
                }
                else if (enrollment[i] != null)
                {
                    ans = false;
                    
                }
                                
            }
            return ans;
        }

        public static bool Test4(Student[] enrollment, int idNumber)
        {
            bool ans = false;
            
            
            for (int i = 0; i < enrollment.Length; i++)
            {              
 
                if (enrollment[i] == null)
                {                    
                    ans = false;

                }
                else if (enrollment[i].GetIDNumber() == idNumber)
                {
                    enrollment[i] = null;
                    ans = true;
                    break;

                }
            }
            return ans;
        }

        public static Student Test5(Student[] enrollment, int idNumber)
        {
            Student s1 = new Student();


            for (int i = 0; i < enrollment.Length; i++)
            {
                

                if (enrollment[i] == null)
                {
                    s1 = null;                    
                }
                else if (enrollment[i].GetIDNumber() == idNumber)
                {
                    s1 = enrollment[i];
                    enrollment[i] = null;                   
                    break;

                }
            }

            return s1;
        }

        
    }
    }

