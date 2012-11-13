/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class SubscriptionEvent : SipEvent {
  private HandleRef swigCPtr;

  internal SubscriptionEvent(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.SubscriptionEvent_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SubscriptionEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SubscriptionEvent() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_SubscriptionEvent(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public tsip_subscribe_event_type_t getType() {
    tsip_subscribe_event_type_t ret = (tsip_subscribe_event_type_t)tinyWRAPPINVOKE.SubscriptionEvent_getType(swigCPtr);
    return ret;
  }

  public SubscriptionSession getSession() {
    IntPtr cPtr = tinyWRAPPINVOKE.SubscriptionEvent_getSession(swigCPtr);
    SubscriptionSession ret = (cPtr == IntPtr.Zero) ? null : new SubscriptionSession(cPtr, false);
    return ret;
  }

}

}
