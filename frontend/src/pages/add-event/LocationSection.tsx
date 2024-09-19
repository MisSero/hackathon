import { FormControl } from './FormControl';
import { FormSection } from './FormSection';

export const LocationSection = () => {
    return (
        <FormSection title="Место проведения">
            <FormControl
                label="Адрес"
                required
            >
                <input placeholder="Введите адрес проведения мероприятия" />
            </FormControl>
            <FormControl
                label="Округ"
                required
            >
                <input placeholder="Введите в каком округе проводится мероприятие" />
            </FormControl>
            <FormControl
                label="Район"
                required
            >
                <input placeholder="Введите в каком районе проводится мероприятие" />
            </FormControl>
        </FormSection>
    );
};
