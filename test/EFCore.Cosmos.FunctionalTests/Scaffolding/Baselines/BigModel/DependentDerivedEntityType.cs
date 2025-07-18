// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Cosmos.Storage.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json.Linq;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<byte?>",
                typeof(CompiledModelTestBase.DependentDerived<byte?>),
                baseEntityType,
                discriminatorProperty: "EnumDiscriminator",
                discriminatorValue: CompiledModelTestBase.Enum1.Two,
                propertyCount: 2);

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(CompiledModelTestBase.DependentDerived<byte?>).GetProperty("Data", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentDerived<byte?>).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20,
                unicode: false);
            data.SetGetter(
                string (CompiledModelTestBase.DependentDerived<byte?> entity) => DependentDerivedUnsafeAccessors<byte?>.Data(entity),
                bool (CompiledModelTestBase.DependentDerived<byte?> entity) => DependentDerivedUnsafeAccessors<byte?>.Data(entity) == null,
                string (CompiledModelTestBase.DependentDerived<byte?> instance) => DependentDerivedUnsafeAccessors<byte?>.Data(instance),
                bool (CompiledModelTestBase.DependentDerived<byte?> instance) => DependentDerivedUnsafeAccessors<byte?>.Data(instance) == null);
            data.SetSetter(
                (CompiledModelTestBase.DependentDerived<byte?> entity, string value) => DependentDerivedUnsafeAccessors<byte?>.Data(entity) = value);
            data.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<byte?> entity, string value) => DependentDerivedUnsafeAccessors<byte?>.Data(entity) = value);
            data.SetAccessors(
                string (IInternalEntry entry) => DependentDerivedUnsafeAccessors<byte?>.Data(((CompiledModelTestBase.DependentDerived<byte?>)(entry.Entity))),
                string (IInternalEntry entry) => DependentDerivedUnsafeAccessors<byte?>.Data(((CompiledModelTestBase.DependentDerived<byte?>)(entry.Entity))),
                string (IInternalEntry entry) => entry.ReadOriginalValue<string>(data, 6),
                string (IInternalEntry entry) => entry.GetCurrentValue<string>(data));
            data.SetPropertyIndexes(
                index: 6,
                originalValueIndex: 6,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            data.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                keyComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                clrType: typeof(string),
                jsonValueReaderWriter: JsonStringReaderWriter.Instance);

            var money = runtimeEntityType.AddProperty(
                "Money",
                typeof(decimal),
                precision: 9,
                scale: 3,
                sentinel: 0m);
            money.SetAccessors(
                decimal (IInternalEntry entry) => entry.ReadShadowValue<decimal>(5),
                decimal (IInternalEntry entry) => entry.ReadShadowValue<decimal>(5),
                decimal (IInternalEntry entry) => entry.ReadOriginalValue<decimal>(money, 7),
                decimal (IInternalEntry entry) => entry.GetCurrentValue<decimal>(money));
            money.SetPropertyIndexes(
                index: 7,
                originalValueIndex: 7,
                shadowIndex: 5,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            money.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<decimal>(
                    bool (decimal v1, decimal v2) => v1 == v2,
                    int (decimal v) => ((object)v).GetHashCode(),
                    decimal (decimal v) => v),
                keyComparer: new ValueComparer<decimal>(
                    bool (decimal v1, decimal v2) => v1 == v2,
                    int (decimal v) => ((object)v).GetHashCode(),
                    decimal (decimal v) => v),
                providerValueComparer: new ValueComparer<decimal>(
                    bool (decimal v1, decimal v2) => v1 == v2,
                    int (decimal v) => ((object)v).GetHashCode(),
                    decimal (decimal v) => v),
                clrType: typeof(decimal),
                jsonValueReaderWriter: JsonDecimalReaderWriter.Instance);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var principalId = runtimeEntityType.FindProperty("PrincipalId");
            var principalAlternateId = runtimeEntityType.FindProperty("PrincipalAlternateId");
            var enumDiscriminator = runtimeEntityType.FindProperty("EnumDiscriminator");
            var id = runtimeEntityType.FindProperty("Id");
            var __id = runtimeEntityType.FindProperty("__id");
            var __jObject = runtimeEntityType.FindProperty("__jObject");
            var data = runtimeEntityType.FindProperty("Data");
            var money = runtimeEntityType.FindProperty("Money");
            var principal = runtimeEntityType.FindNavigation("Principal");
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (IInternalEntry source) =>
                {
                    var entity5 = ((CompiledModelTestBase.DependentDerived<byte?>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long, Guid, CompiledModelTestBase.Enum1, byte?, string, JObject, string, decimal>(((ValueComparer<long>)(((IProperty)principalId).GetValueComparer())).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)(((IProperty)principalAlternateId).GetValueComparer())).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), ((ValueComparer<CompiledModelTestBase.Enum1>)(((IProperty)enumDiscriminator).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.Enum1>(enumDiscriminator)), (source.GetCurrentValue<byte?>(id) == null ? null : ((ValueComparer<byte?>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<byte?>(id))), (source.GetCurrentValue<string>(__id) == null ? null : ((ValueComparer<string>)(((IProperty)__id).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(__id))), (source.GetCurrentValue<JObject>(__jObject) == null ? null : ((ValueComparer<JObject>)(((IProperty)__jObject).GetValueComparer())).Snapshot(source.GetCurrentValue<JObject>(__jObject))), (source.GetCurrentValue<string>(data) == null ? null : ((ValueComparer<string>)(((IProperty)data).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(data))), ((ValueComparer<decimal>)(((IProperty)money).GetValueComparer())).Snapshot(source.GetCurrentValue<decimal>(money)))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<long, Guid>(((ValueComparer<long>)(((IProperty)principalId).GetValueComparer())).Snapshot(default(long)), ((ValueComparer<Guid>)(((IProperty)principalAlternateId).GetValueComparer())).Snapshot(default(Guid))))));
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (IInternalEntry source) => ((ISnapshot)(new Snapshot<long, Guid>(default(long), default(Guid)))));
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => ((ISnapshot)(new Snapshot<long, Guid, CompiledModelTestBase.Enum1, string, JObject, decimal>((source.ContainsKey("PrincipalId") ? ((long)(source["PrincipalId"])) : 0L), (source.ContainsKey("PrincipalAlternateId") ? ((Guid)(source["PrincipalAlternateId"])) : new Guid("00000000-0000-0000-0000-000000000000")), (source.ContainsKey("EnumDiscriminator") ? ((CompiledModelTestBase.Enum1)(source["EnumDiscriminator"])) : CompiledModelTestBase.Enum1.Default), (source.ContainsKey("__id") ? ((string)(source["__id"])) : null), (source.ContainsKey("__jObject") ? ((JObject)(source["__jObject"])) : null), (source.ContainsKey("Money") ? ((decimal)(source["Money"])) : 0M)))));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<long, Guid, CompiledModelTestBase.Enum1, string, JObject, decimal>(default(long), default(Guid), default(CompiledModelTestBase.Enum1), default(string), default(JObject), default(decimal)))));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (IInternalEntry source) =>
                {
                    var entity5 = ((CompiledModelTestBase.DependentDerived<byte?>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long, Guid, object>(((ValueComparer<long>)(((IProperty)principalId).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)(((IProperty)principalAlternateId).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), source.GetCurrentValue<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>>(principal))));
                });
            runtimeEntityType.SetCounts(new PropertyCounts(
                propertyCount: 8,
                navigationCount: 1,
                complexPropertyCount: 0,
                complexCollectionCount: 0,
                originalValueCount: 8,
                shadowCount: 6,
                relationshipCount: 3,
                storeGeneratedCount: 2));
            runtimeEntityType.AddAnnotation("DiscriminatorMappingComplete", false);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
