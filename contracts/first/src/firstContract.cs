// using => imports
using System;
using System.ComponentModel;
using System.Numerics;

using Neo;
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Attributes;
using Neo.SmartContract.Framework.Native;
using Neo.SmartContract.Framework.Services;

namespace First
{
    
    public class FirstContract : SmartContract
    {
        // Las funciones se llaman methods
        public static void AddData(object data)
        {
            // Estoy guardando en Storage en la key name el nombre maikel
            // Lo guardo en el CurrentContext de storage
            Storage.Put(Storage.CurrentContext, "Name", "Maikel");
        }

        public static string getData()
        {
            return Storage.Get(Storage.CurrentContext, "Name");
        }
    }
}