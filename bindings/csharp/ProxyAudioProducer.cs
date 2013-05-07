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

public class ProxyAudioProducer : ProxyPlugin {
  private HandleRef swigCPtr;

  internal ProxyAudioProducer(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.ProxyAudioProducer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyAudioProducer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyAudioProducer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_ProxyAudioProducer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public bool setActualSndCardRecordParams(int nPtime, int nRate, int nChannels) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioProducer_setActualSndCardRecordParams(swigCPtr, nPtime, nRate, nChannels);
    return ret;
  }

  public bool setPushBuffer(IntPtr pPushBufferPtr, uint nPushBufferSize, bool bUsePushCallback) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioProducer_setPushBuffer__SWIG_0(swigCPtr, pPushBufferPtr, nPushBufferSize, bUsePushCallback);
    return ret;
  }

  public bool setPushBuffer(IntPtr pPushBufferPtr, uint nPushBufferSize) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioProducer_setPushBuffer__SWIG_1(swigCPtr, pPushBufferPtr, nPushBufferSize);
    return ret;
  }

  public int push(IntPtr pBuffer, uint nSize) {
    int ret = tinyWRAPPINVOKE.ProxyAudioProducer_push__SWIG_0(swigCPtr, pBuffer, nSize);
    return ret;
  }

  public int push(IntPtr pBuffer) {
    int ret = tinyWRAPPINVOKE.ProxyAudioProducer_push__SWIG_1(swigCPtr, pBuffer);
    return ret;
  }

  public int push() {
    int ret = tinyWRAPPINVOKE.ProxyAudioProducer_push__SWIG_2(swigCPtr);
    return ret;
  }

  public bool setGain(uint nGain) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioProducer_setGain(swigCPtr, nGain);
    return ret;
  }

  public uint getGain() {
    uint ret = tinyWRAPPINVOKE.ProxyAudioProducer_getGain(swigCPtr);
    return ret;
  }

  public void setCallback(ProxyAudioProducerCallback pCallback) {
    tinyWRAPPINVOKE.ProxyAudioProducer_setCallback(swigCPtr, ProxyAudioProducerCallback.getCPtr(pCallback));
  }

  public virtual ulong getMediaSessionId() {
    ulong ret = tinyWRAPPINVOKE.ProxyAudioProducer_getMediaSessionId(swigCPtr);
    return ret;
  }

  public static bool registerPlugin() {
    bool ret = tinyWRAPPINVOKE.ProxyAudioProducer_registerPlugin();
    return ret;
  }

}

}
