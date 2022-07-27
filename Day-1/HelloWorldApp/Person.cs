using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace HelloWorldApp
    {
        public class Person
        {
            private int id;
            private string name;
            private int age;
            private string email;
            private string contactNumber;

            //property
            public int Id
            {
                get { return id; }   //getter
                set { id = value; }  //setter
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (value != "")
                    {
                        name = value;
                    }
                    else
                    {
                        throw new Exception("Name Can Not Be Blank");
                    }
                }
            }
            
        
        public Person()
        {
            this.id = 1;
            this.name = "Suyog";
            this.age = 24;
            this.email = "suyog@gmail.com";
            this.contactNumber = "8275819158";
        }
            public Person(int id, string name, int age, string email, string contactNumber)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.email = email;
                this.contactNumber = contactNumber;
            }

        ~Person()
        {

        }

        //method overriding
        public override string ToString()
        {
            return this.name+" "+this.email+" "+this.age;

        }


    }//class end

    }//package end

