FROM python:3.9
LABEL authors="pona"

COPY requirements.txt ./app/
RUN pip install -r ./app/requirements.txt --no-cache-dir

COPY serv ./app/serv

CMD ["python", "app/serv/manage.py", "runserver","0.0.0.0:8000"]