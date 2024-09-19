import { FormProvider, useForm } from 'react-hook-form';
import { AdditionalSection } from './AdditionalSection';
import { GeneralInfoSection } from './GeneralInfoSection';
import { LocationSection } from './LocationSection';
import { OrganizerSection } from './OrganizerSection';
import './EventForm.scss';

export const EventForm = () => {
    const formMethods = useForm();
    const { handleSubmit } = formMethods;

    return (
        <FormProvider {...formMethods}>
            <form className="eventFormPage__form eventForm">
                <GeneralInfoSection />
                <OrganizerSection />
                <LocationSection />
                <AdditionalSection />
                <button
                    type="submit"
                    className="eventForm__submit"
                >
                    Отправить заявку на модерацию
                </button>
            </form>
        </FormProvider>
    );
};
