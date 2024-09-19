
from django.contrib import admin
from django.urls import path
from django.http import JsonResponse
from django.http import JsonResponse,HttpResponse
from django.views.decorators.csrf import csrf_exempt , ensure_csrf_cookie
import psycopg2
from markdown_pdf import Section
from markdown_pdf import MarkdownPdf
import io

def create_pdf(params):


    pdf = MarkdownPdf(toc_level=2)

    # initializing variables with values

    params = {
        "average_event_count": 30,
        "peak_month": ["май", "июнь", "апрель"],  # месяцы
        "popular_events": ["Посадка деревьев", 30],  # Тип и проценты
        "popular_region": "Чертаново",
        "activity": 120000,  # количество людей
        "online_activity": 23  # проценты
    }

    markdown = """# Статистика по мероприятиям

    ## Количество мероприятий
    В текущем году проводилось в среднем {0} мероприятий.
    Наибольший пик мероприятий приходится на {1}.

    ## Тематика
    Самой популярной тематикой является {2}% процентами.

    ## География
    Самым популярным регионом является {3}.


    ## Участие  
    Всего в экологических мероприятиях учавствовало {4} человек.
    Доля онлайн мероприятий составила {5}% процентов.





    ![image info](./header.jpg)

    """.format(params["average_event_count"], params["peak_month"][0], params["popular_events"],
               params["popular_region"], params["activity"], params["online_activity"])

    pdf.add_section(Section(markdown))
    buffer = io.BytesIO()

    pdf.save(buffer)
    return buffer
@csrf_exempt

def index(request):
    # print(request)
    # body = json.loads(request.body)ss
    # print(body)d
    # loop = asyncio.new_event_loop()
    # asyncio.set_event_loop(loop)s
    # resp =scan_ads(body)
    #
    # return JsonResponse(resp,safe=False)пss


    #connection = psycopg2.connect(database="dbname", user="username", password="pass", host="hostname", port=5432)

    #cursor = connection.cursor()

    buffer = create_pdf(None)

    response = HttpResponse(content_type='application/pdf')
    response['Content-Disposition'] = 'attachment; filename=somefilename.pdf'

    pdf = buffer.getvalue()
    buffer.close()
    response.write(pdf)
    return response


urlpatterns = [
    path('admin/', admin.site.urls),
    path('', index, name='index'),

]
