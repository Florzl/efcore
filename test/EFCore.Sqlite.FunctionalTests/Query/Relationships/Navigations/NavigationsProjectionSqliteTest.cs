﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.Sqlite.Internal;

namespace Microsoft.EntityFrameworkCore.Query.Relationships.Navigations;

public class NavigationsProjectionSqliteTest
    : NavigationsProjectionRelationalTestBase<NavigationsSqliteFixture>
{
    public NavigationsProjectionSqliteTest(NavigationsSqliteFixture fixture, ITestOutputHelper testOutputHelper)
        : base(fixture)
    {
        Fixture.TestSqlLoggerFactory.Clear();
        Fixture.TestSqlLoggerFactory.SetTestOutputHelper(testOutputHelper);
    }

    #region Subquery

    public override async Task Select_subquery_root_set_required_trunk_FirstOrDefault_branch(bool async, QueryTrackingBehavior queryTrackingBehavior)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_subquery_root_set_required_trunk_FirstOrDefault_branch(async, queryTrackingBehavior)))
            .Message);

    public override async Task Select_subquery_root_set_optional_trunk_FirstOrDefault_branch(bool async, QueryTrackingBehavior queryTrackingBehavior)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_subquery_root_set_optional_trunk_FirstOrDefault_branch(async, queryTrackingBehavior)))
            .Message);

    public override async Task Select_subquery_root_set_complex_projection_FirstOrDefault_project_reference_to_outer(
        bool async,
        QueryTrackingBehavior queryTrackingBehavior)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_subquery_root_set_complex_projection_FirstOrDefault_project_reference_to_outer(async, queryTrackingBehavior)))
            .Message);

    public override async Task Select_subquery_root_set_complex_projection_including_references_to_outer_FirstOrDefault(
        bool async,
        QueryTrackingBehavior queryTrackingBehavior)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_subquery_root_set_complex_projection_including_references_to_outer_FirstOrDefault(async, queryTrackingBehavior)))
            .Message);

    public override async Task Select_subquery_root_set_trunk_FirstOrDefault_collection(bool async, QueryTrackingBehavior queryTrackingBehavior)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_subquery_root_set_trunk_FirstOrDefault_collection(async, queryTrackingBehavior)))
            .Message);

    #endregion Subquery
}
