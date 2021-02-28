# cursos-api
API que expõe um CRUD de cursos

docker build -t courses-api:latest .
docker run -d -p 5000:80 courses-api --env ConnectionStringSqlServer=Server=tcp:courses-sandbox.database.windows.net,1433;Initial Catalog=courses;Persist Security Info=False;User ID=courses;Password=Ksn8387LDOgr;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; --env ASPNETCORE_ENVIRONMENT=Development
