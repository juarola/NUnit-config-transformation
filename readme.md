#Config transformations for nunit class lib projects#

**Walkthrough:**

10. Create a new class lib project
20. Add MSBuild.Microsoft.VisualStudio.Web.targets via nuget (`Install-package MSBuild.Microsoft.VisualStudio.Web.targets`)
30. Add solution configs for environments (here dev, test, demo and prod, build->configuration manager->active solution config -dropdown, new "dev", copy settings from release)
40. Add msbuild config transformation to project file. Check end of project file
50. Run builds
60. Execute tests from build assemblies with nunit runner 



*Config transformation in project file:
```
<UsingTask TaskName="TransformXml" AssemblyFile="..\packages\MSBuild.Microsoft.VisualStudio.Web.targets.14.0.0\tools\VSToolsPath\Web\Microsoft.Web.Publishing.Tasks.dll" />
<Target Name="AfterBuild">    
<TransformXml Source="App.config" Transform="App.$(Configuration).config" Destination="$(OutputPath)\$(AssemblyName).dll.config" />
</Target>
```