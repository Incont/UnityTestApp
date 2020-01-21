# UnityTestApp (unity 2019.2.9f1)
App for test Unity asset bundles

My steps: 
1. Build => Do 
2. Remove [PostProcessScene()] from Assets\Editor\BuildAB.cs
3. Build => Do 
4. compare bundles in AssetBundles_21-01-2020-20-03-28 (with PostProcessScene)  and AssetBundles_21-01-2020-20-03-50 (without)
5. assset bundle binary testscenes is equels but has diferent hashes
