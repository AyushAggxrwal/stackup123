// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/reference/acs6.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS6 {

  #region Events
  internal partial class RandomBytesGenerated : aelf::IEvent<RandomBytesGenerated>
  {
    public global::System.Collections.Generic.IEnumerable<RandomBytesGenerated> GetIndexed()
    {
      return new List<RandomBytesGenerated>
      {
      };
    }

    public RandomBytesGenerated GetNonIndexed()
    {
      return new RandomBytesGenerated
      {
        Argument = Argument,
        RandomBytes = RandomBytes,
      };
    }
  }

  #endregion
  internal static partial class RandomNumberProvideacsrContractContainer
  {
    static readonly string __ServiceName = "acs6.RandomNumberProvideacsrContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BytesValue> __Marshaller_google_protobuf_BytesValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BytesValue.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue> __Method_GetRandomBytes = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetRandomBytes",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_google_protobuf_BytesValue);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS6.Acs6Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS6.Acs6Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class RandomNumberProvideacsrContractReferenceState : global::AElf.Sdk.CSharp.State.ContractReferenceState
    {
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue> GetRandomBytes { get; set; }
    }
  }
}
#endregion

