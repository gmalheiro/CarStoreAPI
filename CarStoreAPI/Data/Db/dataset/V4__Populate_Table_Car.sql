INSERT INTO Car (Model, Brand, Color, Plate, LaunchDate, OwnerId)
VALUES
    ('Civic', 'Honda', 'Blue', 'ABC123', '01/01/2020', (SELECT PersonId FROM Person WHERE Name = 'John')),
    ('Corolla', 'Toyota', 'Red', 'XYZ789', '05/02/2019', (SELECT PersonId FROM Person WHERE Name = 'Jane')),
    ('Camry', 'Toyota', 'Silver', 'DEF456', '10/06/2022', (SELECT PersonId FROM Person WHERE Name = 'Bob'));
