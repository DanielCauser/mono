// System.ComponentModel.Design.ServiceCreatorCallback.cs
//
// Author:
// 	Alejandro S�nchez Acosta  <raciel@es.gnu.org>
//
// (C) Alejandro S�nchez Acosta
// 

using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	[ComVisible(true)]
	public delegate object ServiceCreatorCallback (IServiceContainer container, Type serviceType);
}
