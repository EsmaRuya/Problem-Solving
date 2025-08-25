-- Create Master View
SELECT * FROM VehicleDetails;

CREATE VIEW VehicleMasterDetails AS
SELECT  ID,
		VehicleDetails.MakeID,
		Makes.Make,
		VehicleDetails.ModelID,
		MakeModels.ModelName,
		VehicleDetails.SubModelID,
		SubModels.SubModelName,
		VehicleDetails.BodyID,
		Bodies.BodyName,
		Vehicle_Display_Name,
		Year, 
		VehicleDetails.DriveTypeID,
		DriveTypes.DriveTypeName,
		Engine, Engine_CC, 
		Engine_Cylinders, 
		Engine_Liter_Display, 
		VehicleDetails.FuelTypeID, 
		FuelTypes.FuelTypeName,
		NumDoors
FROM VehicleDetails
JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID 
JOIN MakeModels ON  VehicleDetails.ModelID = MakeModels.ModelID
JOIN SubModels ON VehicleDetails.ModelID = SubModels.ModelID 
JOIN FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
JOIN DriveTypes ON VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
JOIN Bodies ON VehicleDetails.BodyID = Bodies.BodyID;

-- DROP VIEW VehicleMasterDetails;

SELECT * FROM VehicleMasterDetails;