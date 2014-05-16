using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodyEqualsFailExample
{
    class Program
    {
        // Class that is altered with Fody.Equals
        [Equals]
        public class SomeClass
        {
            public SomeClass(int number)
            {
                this.Number = number;
            }

            public int Number { get; set; }
        }

        // Class that is semantically equal to the one altered with Fody.Equals
        //public class SomeClass
        //{
        //    public SomeClass(int number)
        //    {
        //        this.Number = number;
        //    }

        //    public int Number { get; set; }

        //    public static bool operator ==(Program.SomeClass left, Program.SomeClass right)
        //    {
        //        return object.Equals((object)left, (object)right);
        //    }
        //    public static bool operator !=(Program.SomeClass left, Program.SomeClass right)
        //    {
        //        return !object.Equals((object)left, (object)right);
        //    }
        //    private static bool EqualsInternal(Program.SomeClass left, Program.SomeClass right)
        //    {
        //        return left.Number == right.Number;
        //    }
        //    public virtual bool Equals(Program.SomeClass other)
        //    {
        //        if (object.ReferenceEquals((object)null, (object)other))
        //            return false;
        //        if (object.ReferenceEquals((object)this, (object)other))
        //            return true;
        //        else
        //            return Program.SomeClass.EqualsInternal(this, other);
        //    }
        //    public override bool Equals(object obj)
        //    {
        //        if (object.ReferenceEquals((object)null, obj))
        //            return false;
        //        if (object.ReferenceEquals((object)this, obj))
        //            return true;
        //        if (this.GetType() == obj.GetType())
        //            return Program.SomeClass.EqualsInternal(this, (Program.SomeClass)obj);
        //        else
        //            return false;
        //    }
        //    public override int GetHashCode()
        //    {
        //        return this.Number;
        //    }
        //}

        static void Main(string[] args)
        {
            var a = new SomeClass(5);
            var b = new SomeClass(5);

            // Both lines should write 'true' on console  
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
        }
    }
}
