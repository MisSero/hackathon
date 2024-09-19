import { FormControl } from './FormControl';
import { FormSection } from './FormSection';
import './AdditionalSection.scss';

export const AdditionalSection = () => {
    return (
        <FormSection
            className="additionalSection"
            title="Дополнительные данные"
        >
            <FormControl
                label="Тип мероприятия"
                required
            >
                <input placeholder="Введите тип мероприятия" />
            </FormControl>
            <FormControl label="Теги">
                <input placeholder="Введите подходящие теги" />
            </FormControl>
            <FormControl
                label="Описание"
                required
            >
                <textarea
                    className="additionalSection__description"
                    placeholder="Введите описание мероприятия"
                />
            </FormControl>
        </FormSection>
    );
};
