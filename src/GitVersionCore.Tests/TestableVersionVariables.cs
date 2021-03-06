﻿namespace GitVersionCore.Tests
{
    using GitVersion;

    class TestableVersionVariables : VersionVariables
    {
        public TestableVersionVariables(string major = "", string minor = "", string patch = "", string buildMetaData = "", string buildMetaDataPadded = "", string fullBuildMetaData = "", string branchName = "", string sha = "", string majorMinorPatch = "", string semVer = "", string legacySemVer = "", string legacySemVerPadded = "", string fullSemVer = "", string assemblySemVer = "", string preReleaseTag = "", string preReleaseTagWithDash = "", string informationalVersion = "", string commitDate = "", string nugetVersion = "", string nugetVersionV2 = "", string commitsSinceVersionSource = "", string commitsSinceVersionSourcePadded = "") : base(major, minor, patch, buildMetaData, buildMetaDataPadded, fullBuildMetaData, branchName, sha, majorMinorPatch, semVer, legacySemVer, legacySemVerPadded, fullSemVer, assemblySemVer, preReleaseTag, preReleaseTagWithDash, informationalVersion, commitDate, nugetVersion, nugetVersionV2, commitsSinceVersionSource, commitsSinceVersionSourcePadded)
        {
        }
    }
}
