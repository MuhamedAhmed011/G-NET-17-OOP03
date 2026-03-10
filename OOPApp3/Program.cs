using System.Security.AccessControl;

namespace OOPApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //a) Composition – The departments depend completely on the university,
            //so if the university is closed the departments no longer exist.

            //b) Association – The driver only uses the car, and both the driver and the car can exist independently.

            //c) Inheritance – A dog is a type of animal, so Dog inherits from the Animal class.

            //d) Aggregation – A team has players, but the players can still exist even if the team is deleted.

            //e) Dependency – The method temporarily uses the logger as a parameter only inside the method. 
            #endregion

            #region Question02
            //a) Yes, a child class in another assembly can access a protected field if it inherits from the parent.
            //No, it cannot be accessed through an object instance from outside.

            //b) protected internal → accessible in the same assembly or by derived classes in other assemblies.
            //private protected → accessible only by derived classes within the same assembly.

            //c) sealed class → cannot be inherited.
            //sealed method → cannot be overridden.

            //d) Yes, you can create an object from a sealed class using new,
            //because sealing only prevents inheritance. 
            #endregion
        }
    }
}
