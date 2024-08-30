# Secure Privacy Full-Stack Tech Test

A short full-stack tech test using a HTML, JavaScript and CSS frontend; a C# .NET web API backend; MongoDB for data persistence. The repository is setup as a monorepo with both the frontend and backend code housed here.

## Install Build & Run

Installation:

- Node.js
  - Using your preferred package manager (NVM is recommended) [Node.js download](https://nodejs.org/en/download/package-manager)
- Dotnet 8.0
  - MacOS using [homebrew](https://brew.sh/) `brew install --cask dotnet`
  - Directly from their website for all platforms [dotnet](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Docker
  - MacOS using [homebrew](https://brew.sh/) `brew install docker`
  - Directly from their website for all platforms [Docker download](https://docs.docker.com/engine/install/)

How to build and run the project:

- Use two different terminals running and navigate one to the `/backend` folder and the other to the `/frontend` folder
- Backend
  - `docker compose up -d` will install the latest version of the MongoDB container image and run it locally
  - `docker compose down` can be used to stop the MongoDB container instance
  - See the `docker-compose.yml` file for details where port `27017` is being exposed and the `/db` folder of this project is being used to persist data outside of Docker
  - `dotnet run` can be used to run the .NET web API from the command line or alternatively use your own run configuration
  - The web API will be served locally at [localhost:7013](https://localhost:7013/)
- Frontend
  - `npx -y http-server` will run a basic HTTP server for your project files
  - index.html will be served on [localhost:8080](http://localhost:8080)

## Task 1 - Backend

The `/backend` folder of this monorepo has a template project with a working `Program.cs` but no controllers, services, models or repositories. Your task is to create new entities which will be stored in your local MongoDB instance, creating files in each of the named folders to follow the existing design system in the provided template.

1. Create a new `User` entity with create, read, update and delete (CRUD) functionality
2. Create a new `Consent` entity with CRUD functionality
3. Ensure that a consent record can be linked to a user record

You will be marked on the following criteria:

- Code functionality and completeness of the task at hand
- Code design, readability and efficiency so that solution will scale
- Careful GDPR consideration of the fields used in each of the entities and how they are stored

## Task 2 - Frontend

The `/frontend` folder of this monorepo has only an `index.html` file with some basic form components and an empty `main.js` and `style.css` file ready to add interactivity and design to the page.

1. Extend the simple user creation form to match the fields in your `User` entity from Task 1
2. Write JavaScript code which will send a create user request to the backend when the form is submitted
3. Considering GDPR compliance best practices create a way for the user to consent to the terms & conditions of this website and store that information in the `Consent` entity from Task 1
4. Improve the basic design of the form to provide a good user-interface (UI) and user-experience (UX)

You will be marked on the following criteria:

- Code functionality and completeness of the task at hand
- Code design, readability and efficiency so that solution will scale
- GDPR compliance for obtaining consent
- The UI and UX of your solution

## Submission Guidelines

- Allocate 1-3 hours for this task depending on your experience with the tech stack
- The use of frontend JavaScript frameworks is prohibited and your solution must be written solely in vanilla JavaScript
- The use of AI is not prohibited but if the entire solution is found to be largely written by AI then it will be discredited - use AI sparingly and not as the foundation of your solution
- Submit your solution as a public repository with an explanation of your code in the README.md implementation section below
- Email the repository link to [james@secureprivacy](mailto:james@secureprivacy.ai) and [dan@secureprivacy](mailto:dan@secureprivacy.ai)

## Implementation

ToDo: Add your code explanation here
