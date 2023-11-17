# A contact management REST API service using C# and .NET 6

The API service runs in a Docker container and communicates with the PostgreSQL server running in a separate container, both forming a single Docker Compose orchestrated service.

## Features
- The API provides the following methods:
  - Create a contact
  - Update an existing contact
  - Delete an existing contact
  - Read a contact by a given id
  - Read all contacts
- Uses a PostgreSQL database
- Provides a Swagger endpoint

## Entity / Business Object
A contact has the following properties and requirements:
| Name | Description | Requirement |
| :---       | :---      | :---    |
| Salutation | The contact's salutation | Cannot be empty, must be longer than 2 characters, can be changed |
| First Name | The contact's first name | Cannot be empty, must be longer than 2 characters, can be changed |
| Last Name | The contact's last name | Cannot be empty, must be longer than 2 characters |
| Displayname | The contact's display name | If empty it will be filled automatically with salutation + firstname + surname, can be changed |
| Birthdate | The contact's birthdate | Can be empty, can be changed |
| CreationTimestamp | The time when the contact was created | Cannot be changed |
| LastChangeTimestamp | The time when the contact was last changed | Cannot be set |
| NotifyHasBirthdaySoon | Indicates if the contact has a birthday in the next 14 days | Cannot be set |
| Email | The contact's email address | Cannot be empty, can be changed, is unique |
| Phone number | The contact's phone number | Can be empty, can be changed |

## Prerequisites
- Visual Studio 2022
- Microsoft.AspNetCore.App
- Microsoft.NETCore.App
- Microsoft.EntityFrameworkCore (6.0.25)
- Microsoft.EntityFrameworkCore.Tools (6.0.25)
- Microsoft.VisualStudio.Azure.Containers.Tools.Targets (1.19.4)
- Npgsql.EntityFrameworkCore.PostgreSQL (6.0.22)
- Swashbuckle.AspNetCore (6.5.0)