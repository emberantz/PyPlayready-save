﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Media.PlayReadyClient.PlayReadyContentResolver
// Assembly: Microsoft.Media.PlayReadyClient, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 2D6E2780-4223-41EE-BB06-D22D01925C6F
// Assembly location: D:\1_Netflix\PlayReady\microsoft.media.playreadyclient.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Media.PlayReadyClient
{
  [Static(typeof (IPlayReadyContentResolver), 100794368)]
  [Version(100794368)]
  public static class PlayReadyContentResolver
  {
    [MethodImpl]
    public static extern IPlayReadyServiceRequest ServiceRequest(
      PlayReadyContentHeader contentHeader);
  }
}
