﻿namespace NebulaModel.Packets.Logistics
{
    public class ILSRemoveStationComponent
    {
        public int StationId { get; set; }
        public int PlanetId { get; set; }
        public int StationGId { get; set; }
        public ILSRemoveStationComponent() { }
        public ILSRemoveStationComponent(int stationId, int planetId, int stationGId)
        {
            StationId = stationId;
            PlanetId = planetId;
            StationGId = stationGId;
        }
    }
}
