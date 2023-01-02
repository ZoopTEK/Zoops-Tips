using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public static class ExampleExtensions
    {
        /// <summary>
        /// Example extension method, callable on MyClass instances.
        /// </summary>
        /// <param name="myClassInstance">My class instance.</param>
        public static void ThisMethodDoesNotExist(this MyClass myClassInstance)
        {
            Debug.Log(myClassInstance.name);
        }

        /// <summary>
        /// ThisMethodDoesNotExist example.
        /// </summary>
        public static void ThisMethodDoesNotExistExample()
        {
            MyClass instance = new MyClass();
            instance.ThisMethodDoesNotExist(); //calling extension method
        }

        /// <summary>
        /// Prints the name of the given game object.
        /// </summary>
        /// <param name="gameObject">The game object.</param>
        public static void PrintName(this GameObject gameObject) //static + this keywords in a static class make it an extension method.
        {
            Debug.Log(gameObject.name); //print the game object's name
        }

        /// <summary>
        /// Executes the example extension method.
        /// </summary>
        public static void PrintNameExtensionUsage()
        {
            GameObject exampleGameObject = new GameObject("Hello There"); //Create a new game object with the name, "Hello There."
            exampleGameObject.PrintName(); //Will print "Hello There" to the console.
        }

        public static void GetOrAddComponentExtensionUsage()
        {
            GameObject exampleGameObject = new GameObject(); //Create a new game object
            //get the existing rigid body, or add one if missing
            Rigidbody rigidbody = exampleGameObject.GetOrAddComponent<Rigidbody>();
        }
    }
}
