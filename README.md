# XR-OOM
Augmented Reality On rOad siMulation. This reposity serves as version control and back-up of the Unity project.

1. Open project folder through Unity Hub. Version needed is 2019.4.12f1.
2. Open Varjo Base.
3. Open Dtrack3 and start tracking. Always make sure checkbox "Tracking > Output Settings > act as router for tracking output" is selected, in case the tracking data is not received in Varjo Base.

A virtual object is generated at the location between markers 303 and 308 (printed on A4 paper). The code for generating the virtual object is stored in MarkerManager.cs inside the object "Markers".
Currently there is a hardcoded offset in order to have the virtual object appear at the correct location. 

