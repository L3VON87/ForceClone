﻿using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

// La información general de un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie estos valores de atributo para modificar la información
// asociada con un ensamblado.
[assembly: AssemblyTitle("ForceClone")]
[assembly: AssemblyDescription("Allows force cloning of a VRChat avatar if it is public")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ForceClone")]
[assembly: AssemblyCopyright("Copyright © 2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Si establece ComVisible en false, los tipos de este ensamblado no estarán visibles 
// para los componentes COM.  Si es necesario obtener acceso a un tipo en este ensamblado desde 
// COM, establezca el atributo ComVisible en true en este tipo.
[assembly: ComVisible(false)]

// El siguiente GUID sirve como id. de typelib si este proyecto se expone a COM.
[assembly: Guid("c2e74d1f-e8b0-4d9b-93d3-e1dab29508ce")]

// La información de versión de un ensamblado consta de los cuatro valores siguientes:
//
//      Versión principal
//      Versión secundaria
//      Número de compilación
//      Revisión
//
// Puede especificar todos los valores o usar los valores predeterminados de número de compilación y de revisión
// utilizando el carácter "*", como se muestra a continuación:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: MelonInfo(typeof(ForceClone.Main), "Force Clone", "1.0.7", "matix#9090")]
[assembly: MelonGame("VRChat", "VRChat")]
