/* INFORMACIÓN RELEVANTE */

// Se utilizo este comando para crear la migración inicial. EntityFrameworkCore\Add-Migration CreateSchema -project Travel.Infrastructure -OutputDir "Data/Migrations"

// Se utilizo este comando para ejecutar la migración inicial y crear la base de datos. EntityFrameworkCore\Update-Database -project Travel.Infrastructure

// Los 2 comandos anteriores dependen de la clase “ApplicationDbContextFactory” y su cadena de conexión a la base de datos.

// Como archivo adjunto, en el folder “Solution Items”, se encuentra una copia de respaldo de la base de datos como se solicitó, pero no es necesario restaurarla ya que esta debe crearse y alimentarse automáticamente la primera vez que se ejecute la aplicación.

/* REALIZAR ESTE CAMBIO ANTES DE LA PRIMERA EJECUCIÓN */

// La ejecución de la aplicación depende de la cadena de conexión establecida en el archivo de configuración “appsettings.json”, por favor cambiar el valor de “DefaultConnection” antes de ejecutar la aplicación si desea utilizar una configuración diferente, se configuro por defecto para utilizar archivo de datos, localdb.