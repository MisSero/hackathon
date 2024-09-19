import { Card } from '@/shared/ui/card/Card';
import event1 from '@/shared/ui/images/event1.png';
import { EventsBanner } from '@/widgets/EventsBanner/EventsBanner';
import './EventsPage.scss';

export const EventsPage = () => {
    return (
        <>
            <EventsBanner />
            <div className="eventsPage">
                <main className="eventsPage__events">
                    <h1 className="eventsPage__title">Экологические мероприятия Москвы</h1>
                    <Card
                        img={event1}
                        title="Экологическая игра - викторина EcoFreedom"
                        link="/events/1"
                        description="Московская обл., г. Москва, ул. Вавилова, 45"
                        info="Суббота, 21 сентября"
                    />
                </main>
            </div>
        </>
    );
};
