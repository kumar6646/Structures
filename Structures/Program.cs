using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    /*New Line Added
     * Structure: 
     * structure is value type. 
     * when we create an object for structure it will
     * be allocated into stack memory.
     * To define structure we have to use struct keyword.
     * Structure is a collection of members like varibales,properies,constructors
     * methods and so on
     * syntax:
     * <accessmodifier>struct <structurename>
     * {
     * members
     * }
     * Default access modifiers of structure is internal.
     * Default acess modifiers of structure members will be private.
     * we can create an object for structure without using new keyword 
     * only when the structure doesnot have instance varibales.
     * we cannot define explict parameterless constructor with in the structure.
     * we cannot initialize instance varibales of a structure by using
     * instance fields initialized for this we have to go for either
     * parameterized constructor or property.
     * structure can contain static members.
     * We cannot have static ,abstract ,sealed structures.
     * but we can have partial structure and generic structure.
     * structure will not support inheritance due to that reason using
     * structure we cannot implement overiding but we can
     * implement overloading
     * Access modifiers of structure and structure members cannot be protected
     * and protected internal.
     */

    struct Employee
    {
        int eno;
        string ename;
        static string compname;
        static Employee()
        {
            compname = "ICICI";
        }
        internal Employee(int eno, string ename)
        {
            this.eno = eno;
            this.ename = ename;
        }
        public void Display()
        {
            Console.WriteLine("Employee number is " + eno);
            Console.WriteLine("Employee name is" + ename);
            Console.WriteLine("Employee company name is"+compname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "ABC");
            e.Display();
        }
    }
}
