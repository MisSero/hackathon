import { FormControl } from './FormControl';
import { FormSection } from './FormSection';

export const OrganizerSection = () => (
    <FormSection title="Данные об организаторе">
        <FormControl
            label="Название организации"
            required
        >
            <input placeholder="Введите название организации" />
        </FormControl>
        {/* <FormControl
            label="Тип организации"
            required
        >
            <label>
                Юр. лицо
                <input type="radio" value="jurperson" />
            </label>
            <label>
                НКО
                <input type="radio" value="" />
            </label>
        </FormControl> */}
        <FormControl label="ИНН">
            <input placeholder="Введите ИНН" />
        </FormControl>
        <p>или</p>
        <FormControl label="ОГРН">
            <input placeholder="Введите ОГРН организации" />
        </FormControl>
        <FormControl label="Контактный телефон">
            <input placeholder="Введите ОГРН организации" />
        </FormControl>
    </FormSection>
);
