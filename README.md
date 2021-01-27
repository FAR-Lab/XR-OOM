# XR-OOM
Augmented Reality On rOad siMulation. This reposity serves as version control and back-up of the Unity project.

1. Open project folder through Unity Hub. Version needed is 2019.4.12f1.
2. Open Varjo Base.
3. Open Dtrack3 and start tracking. Always make sure checkbox "Tracking > Output Settings > act as router for tracking output" is selected, in case the tracking data is not received in Varjo Base.

Note about marker IDs
1 marker is used above ZedMini, marker ID is 200 (assigned in XR-OOM/Assets/Scripts/SimpleMarkerManager.cs)
3 markers are used to align ground plane, marker IDs are 201, 202, 203 (assigned in XR-OOM/Assets/GroundMarkerManager.cs)

Marker guidelines: use as large a marker as possible. https://developer.varjo.com/docs/get-started/varjo-markers
25mm (~1”) Tracked up-to 0.5 meter (1.5 feet) 
50mm (~2”) Tracked up-to 1 meter (3 feet) 
150mm (~6”) Tracked up-to 3 meters (9 feet)

