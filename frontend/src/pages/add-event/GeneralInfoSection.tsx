import { FormControl } from './FormControl';
import { FormSection } from './FormSection';

export const GeneralInfoSection = () => {
    return (
        <FormSection  title="Основные данные о мероприятии">
            <FormControl
                label="Название мероприятия"
                required
            >
                <input placeholder="Введите название мероприятия" />
            </FormControl>
            <div className="eventFormPage__date row">
                <FormControl
                    label="Дата начала мероприятия"
                    required
                >
                    <input type="date" />
                </FormControl>
                <FormControl label="Дата окончания мероприятия">
                    <input type="date" />
                </FormControl>
            </div>
            <div className="eventFormPage__time row">
                <FormControl
                    label="Время начала мероприятия"
                    required
                >
                    <input type="date" />
                </FormControl>
                <FormControl label="Время окончания мероприятия">
                    <input type="date" />
                </FormControl>
            </div>
        </FormSection>
    );
};
