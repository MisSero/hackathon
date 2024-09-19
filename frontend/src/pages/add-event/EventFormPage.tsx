import { EventForm } from './EventForm';
import './EventFormPage.scss';

export const EventFormPage = () => {
    return (
        <div className="eventFormPage">
            <main className="eventFormPage__content">
                <h1 className="eventFormPage__title">Создать мероприятие</h1>
                <EventForm />
            </main>
        </div>
    );
};
