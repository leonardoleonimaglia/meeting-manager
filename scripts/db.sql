CREATE TABLE Users (
    Id INTEGER CONSTRAINT pk_id_user PRIMARY KEY,
    FirstName VARCHAR(40) NOT NULL,
    LastName VARCHAR(40) NOT NULL,
    Email VARCHAR(80) NOT NULL,
    Password VARCHAR(80) NOT NULL,
    ActivationDate DATE,
    CreatedDate DATE
);

CREATE TABLE MeetingRooms (
    Id INTEGER CONSTRAINT pk_id_meeting_rooms PRIMARY KEY,
    Name VARCHAR(60) NOT NULL,
    Floor INTEGER NOT NULL,
    PeopleLimit INTEGER NOT NULL,
    Television BOOLEAN NOT NULL,
    WiredNetwork BOOLEAN NOT NULL,
    Projector BOOLEAN NOT NULL
);

CREATE TABLE Reservations (
    Id INTEGER CONSTRAINT pk_id_reservations PRIMARY KEY,
    WhoBooked INTEGER REFERENCES Users (Id),
    MeetingRoomId INTEGER REFERENCES MeetingRooms (Id),
    StartDate DATE,
    EndDate DATE
);

CREATE TABLE Invites (
    ReservationId INTEGER REFERENCES Reservations (Id),
    UserId INTEGER REFERENCES Users (Id)
);
