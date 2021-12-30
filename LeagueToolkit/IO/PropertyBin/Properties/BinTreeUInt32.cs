﻿using System.IO;

namespace LeagueToolkit.IO.PropertyBin.Properties;

public sealed class BinTreeUInt32 : BinTreeProperty
{
    public BinTreeUInt32(IBinTreeParent parent, uint nameHash, uint value) : base(parent, nameHash)
    {
        Value = value;
    }

    internal BinTreeUInt32(BinaryReader br, IBinTreeParent parent, uint nameHash) : base(parent, nameHash)
    {
        Value = br.ReadUInt32();
    }

    public override BinPropertyType Type => BinPropertyType.UInt32;
    public uint Value { get; set; }

    protected override void WriteContent(BinaryWriter bw)
    {
        bw.Write(Value);
    }

    internal override int GetSize(bool includeHeader)
    {
        var size = includeHeader ? 5 : 0;
        return size + 4;
    }

    public override bool Equals(BinTreeProperty other)
    {
        return other is BinTreeUInt32 property
               && NameHash == property.NameHash
               && Value == property.Value;
    }

    public static implicit operator uint(BinTreeUInt32 property)
    {
        return property.Value;
    }
}