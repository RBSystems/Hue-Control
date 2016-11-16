using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_HUE_CONTROL___BRIDGE_FINDER
{
    public class UserModuleClass_HUE_CONTROL___BRIDGE_FINDER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput FIND_IP;
        Crestron.Logos.SplusObjects.AnalogInput BRIDGE_NO;
        Crestron.Logos.SplusObjects.AnalogOutput NO_OF_BRIDGES;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_BRIDGE_NO;
        Crestron.Logos.SplusObjects.AnalogOutput BRIDGE_IP;
        
        public override void LogosSplusInitialize()
        {
            SocketInfo __socketinfo__ = new SocketInfo( 1, this );
            InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
            _SplusNVRAM = new SplusNVRAM( this );
            
            FIND_IP = new Crestron.Logos.SplusObjects.DigitalInput( FIND_IP__DigitalInput__, this );
            m_DigitalInputList.Add( FIND_IP__DigitalInput__, FIND_IP );
            
            BRIDGE_NO = new Crestron.Logos.SplusObjects.AnalogInput( BRIDGE_NO__AnalogSerialInput__, this );
            m_AnalogInputList.Add( BRIDGE_NO__AnalogSerialInput__, BRIDGE_NO );
            
            NO_OF_BRIDGES = new Crestron.Logos.SplusObjects.AnalogOutput( NO_OF_BRIDGES__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( NO_OF_BRIDGES__AnalogSerialOutput__, NO_OF_BRIDGES );
            
            OUTPUT_BRIDGE_NO = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_BRIDGE_NO__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( OUTPUT_BRIDGE_NO__AnalogSerialOutput__, OUTPUT_BRIDGE_NO );
            
            BRIDGE_IP = new Crestron.Logos.SplusObjects.AnalogOutput( BRIDGE_IP__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( BRIDGE_IP__AnalogSerialOutput__, BRIDGE_IP );
            
            
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_HUE_CONTROL___BRIDGE_FINDER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint FIND_IP__DigitalInput__ = 0;
        const uint BRIDGE_NO__AnalogSerialInput__ = 0;
        const uint NO_OF_BRIDGES__AnalogSerialOutput__ = 0;
        const uint OUTPUT_BRIDGE_NO__AnalogSerialOutput__ = 1;
        const uint BRIDGE_IP__AnalogSerialOutput__ = 2;
        
        [SplusStructAttribute(-1, true, false)]
        public class SplusNVRAM : SplusStructureBase
        {
        
            public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
            
            
        }
        
        SplusNVRAM _SplusNVRAM = null;
        
        public class __CEvent__ : CEvent
        {
            public __CEvent__() {}
            public void Close() { base.Close(); }
            public int Reset() { return base.Reset() ? 1 : 0; }
            public int Set() { return base.Set() ? 1 : 0; }
            public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
        }
        public class __CMutex__ : CMutex
        {
            public __CMutex__() {}
            public void Close() { base.Close(); }
            public void ReleaseMutex() { base.ReleaseMutex(); }
            public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
        }
         public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
    }
    
    
}
