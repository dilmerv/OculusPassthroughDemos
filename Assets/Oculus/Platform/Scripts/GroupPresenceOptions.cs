// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform
{
  using System;
  using System.Collections;
  using Oculus.Platform.Models;
  using System.Collections.Generic;
  using UnityEngine;

  public class GroupPresenceOptions {

    public GroupPresenceOptions() {
      Handle = CAPI.ovr_GroupPresenceOptions_Create();
    }

    /// This the unique API Name that refers to an in-app destination
    public void SetDestinationApiName(string value) {
      CAPI.ovr_GroupPresenceOptions_SetDestinationApiName(Handle, value);
    }

    /// Set whether or not the person is shown as joinable or not to others
    public void SetIsJoinable(bool value) {
      CAPI.ovr_GroupPresenceOptions_SetIsJoinable(Handle, value);
    }

    /// This is a session that represents a group/squad/party of users that are to
    /// remain together across multiple rounds, matches, levels maps, game modes,
    /// etc. Users with the same lobby session id in their rich presence will be
    /// considered together.
    public void SetLobbySessionId(string value) {
      CAPI.ovr_GroupPresenceOptions_SetLobbySessionId(Handle, value);
    }

    /// This is a session that represents all the users that are playing a specific
    /// instance of a map, game mode, round, etc. This can include users from
    /// multiple different lobbies that joined together and the users may or may
    /// not remain together after the match is over. Users with the same match
    /// session id in their rich presence is also considered to be together but
    /// have a looser connection than those together in a lobby session.
    public void SetMatchSessionId(string value) {
      CAPI.ovr_GroupPresenceOptions_SetMatchSessionId(Handle, value);
    }


    /// For passing to native C
    public static explicit operator IntPtr(GroupPresenceOptions options) {
      return options != null ? options.Handle : IntPtr.Zero;
    }

    ~GroupPresenceOptions() {
      CAPI.ovr_GroupPresenceOptions_Destroy(Handle);
    }

    IntPtr Handle;
  }
}
