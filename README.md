Solution for Exercise 1: 
•	Add the Gravity property to the Moon class, calculating it based on the mass information. 
•	Formula: ‘MassValue * Math.Pow(10, MassExponent)’
•	Ensure the Planet class correctly calculates the AverageMoonGravity.

Solution for Exercise 2: 
Alternative Solution:
Instead of calculating gravity on-the-fly within the Planet class, precompute and store the gravity value for each moon when data is fetched.
Benefit:
•	Reduces computation overhead during property access, as gravity is precomputed.
Drawback:
•	Requires additional storage and synchronization if source data changes.
With these updates, the AverageMoonGravity property should now correctly reflect the average gravity of the moons for each planet, using the mass values provided by the API.
