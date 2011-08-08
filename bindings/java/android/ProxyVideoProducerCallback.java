/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.doubango.tinyWRAP;

public class ProxyVideoProducerCallback {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public ProxyVideoProducerCallback(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(ProxyVideoProducerCallback obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPJNI.delete_ProxyVideoProducerCallback(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    tinyWRAPJNI.ProxyVideoProducerCallback_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    tinyWRAPJNI.ProxyVideoProducerCallback_change_ownership(this, swigCPtr, true);
  }

  public ProxyVideoProducerCallback() {
    this(tinyWRAPJNI.new_ProxyVideoProducerCallback(), true);
    tinyWRAPJNI.ProxyVideoProducerCallback_director_connect(this, swigCPtr, swigCMemOwn, false);
  }

  public int prepare(int width, int height, int fps) {
    return (getClass() == ProxyVideoProducerCallback.class) ? tinyWRAPJNI.ProxyVideoProducerCallback_prepare(swigCPtr, this, width, height, fps) : tinyWRAPJNI.ProxyVideoProducerCallback_prepareSwigExplicitProxyVideoProducerCallback(swigCPtr, this, width, height, fps);
  }

  public int start() {
    return (getClass() == ProxyVideoProducerCallback.class) ? tinyWRAPJNI.ProxyVideoProducerCallback_start(swigCPtr, this) : tinyWRAPJNI.ProxyVideoProducerCallback_startSwigExplicitProxyVideoProducerCallback(swigCPtr, this);
  }

  public int pause() {
    return (getClass() == ProxyVideoProducerCallback.class) ? tinyWRAPJNI.ProxyVideoProducerCallback_pause(swigCPtr, this) : tinyWRAPJNI.ProxyVideoProducerCallback_pauseSwigExplicitProxyVideoProducerCallback(swigCPtr, this);
  }

  public int stop() {
    return (getClass() == ProxyVideoProducerCallback.class) ? tinyWRAPJNI.ProxyVideoProducerCallback_stop(swigCPtr, this) : tinyWRAPJNI.ProxyVideoProducerCallback_stopSwigExplicitProxyVideoProducerCallback(swigCPtr, this);
  }

}
