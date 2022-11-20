# Fabric
Данная база данных предназначена для учёта сырья на кондитерской фабрике.
Позволяет отслеживать логистику сырья на кондитерской фабрике*
_________________________________________________________________________

# Начало работы
Требуется скачать архив, а после распаковать его.
_________________________________________________________________________

# Предварительно
Требуется скачать Visual Stidio, SQL Server, My SQL Server
Ознакомиться с руководством 
_________________________________________________________________________

# Установка Visual Studio
1. Зайти на сайт  скачайте файл начального загрузчика *Visual Studio*, для этого выберите нужный выпуск *Visual Studio*, щелкните *Сохранить*, а затем *Открыть* папку.
2. В папке Загрузки дважды щелкните файл начального загрузчика, имя которого совпадает с именем одного из следующих файлов или похоже на них:
   vs_community.exe для Visual Studio Community.
   vs_professional.exe для Visual Studio Professional;
   vs_enterprise.exe для Visual Studio Enterprise;
3. Когда завершится установка программы установки, вы можете с ее помощью выбрать нужные наборы функций (рабочих нагрузок),выбрав нужные рабочие нагрузки,нажмите кнопку    *установить*. Далее будут отображаться экраны состояния, на которых демонстрируется ход установки *Visual Studio*.  
4. Если вы не хотите пользоваться функцией рабочих нагрузок для настройки установки Visual Studio или хотите добавить дополнительные компоненты, которые не устанавливает    рабочая нагрузка, это можно сделать путем установки или добавления отдельных компонентов на вкладке *Отдельные компоненты*.
5. Когда установка Visual Studio завершится, нажмите кнопку Запустить, чтобы приступить к разработке в Visual Studio.
_________________________________________________________________________

# Установка SQL Server
1. Скачиваем дистрибутив Microsoft SQL Server.
2. Далее открываем установщик и начинаем инсталляцию приложения. Нажатием на вкладку *Новая установка изолированного экземпляра SQL Server или добавление к существующей установке*.
3. Далее, у нас запросят выбрать версию установки из бесплатных, к примеру Evaluation (ознакомительня версия).Если у Вас есть ключ активации от полнофункциональной версии, к примеру SQL Server 2019 Standard, то в нижнее поле можете ввести его.
4. Далее, Вам предлагается выбрать компоненты для установки в SQL Server, выбираете нужные под Ваши задачи и жмем далее.
5. Далее, переходим к настройкам конфигурации сервера, обратим внимание на раздел *Имя учетной записи* - это те учетные записи из под которых будут стартовать службы.    По умолчанию используется Ваша локальная учетная запись.
6. Далее переходим к настройкам учетных записей для подключения к SQL Server. Нам предлагают выбор режим входа под учетными записями Windows, либо смешанный режим, т.е    возможность входа под учетной записью Windows и под учетной записью SQL Server, если выбрать смешанную, то Вам предложится создать учетную запись SQL Server.
7. Теперь в следующем окне Вы можете наблюдать все установки и настройки, которые вы ранее задавали. Нажимаем *Установить*.
8. После того, как установка SQL Server 2019 завершена, нам нужно установить приложение, с помощью которого мы будем подключаться к серверу баз данных. Это приложение    *SQL Server Management Studio*.
9. Заходим снова в центр установки SQL Server и наживаем *Установить средства управления SQL Server*.Если все прошло успешно, закрываем окно.
___________________________________________________________________________

# Установка My SQL Server
1. Чтобы перейти к установке MySQL Server, сначала необходимо скачать дистрибутив этой программы. Скачать MySQL Server можно абсолютно свободно с официального сайта.
2. Далее запускаем скаченный файл, в итоге запустится программа установки MySQL. Сначала выбираем тип установки, Вариант по умолчанию, т.е. Developer, подойдет для        большинства случаев, особенно если Вы устанавливаете MySQL на домашнем компьютере.
3. Затем программа установки проверит систему на наличие компонентов, которые требуются для работы некоторых расширений MySQL.
4. Все готово для установки MySQL, на данном шаге программа установки выдаст все компоненты MySQL, которые готовы к установке, нажимаем *Execute*.
5. Когда все компоненты установлены, но не все настроены, необходимо их настроить. Программа установки покажет, какие конкретно компоненты требуется настроить.
6. Первым делом настраиваем параметр *High Availability*, который отвечает за то, как будет установлен MySQL сервер. В нашем случае, как и в большинстве других            требуется стандартный «Standalone MySQL Server».
7. Далее настраиваем все последующие компоненты по умолчанию.
8. Все параметры MySQL Server настроены, однако нам еще нужно их применить и сохранить. Для этого на следующем окне нажимаем *Execute*. Когда все галочки будут            проставлены и отобразится сообщение *Successful*, процесс будет завершен, нажимаем *Finish*.
9. MySQL Server и все необходимые для работы с ним компоненты установлены и настроены: это и MySQL Workbench, и различные коннекторы, и документация, и даже тестовая б    база данных.
