# aidn-assignment

## Overview

There are two projects in this Repo:

[aidn-news-frontend](./aidn-news-frontend/README.md)
[AidnNews - Backend](./AidnNews/Readme.md)

## Running the Applications

### Backend
```bash
cd AidnNews
dotnet build
dotnet run
```

* Backend will be running at http://localhost:5000
* Swagger can be found at http://localhost:5000/swagger

### Frontend

```bash
cd aidn-news-frontend
npm install
npm run dev
```

.env.example contains the URL for the backend, you will need to Clone it and create an `.env.development` file.
