import { NavigationLogo } from '@/shared/ui/logo/NavigationLogo';
import { AddIcon, UserIcon } from '@/shared/ui/icons';
import { Link } from 'react-router-dom';
import './AppHeader.scss';

export const AppHeader = () => (
    <header className="appHeader">
        <NavigationLogo className="appHeader__logo" />
        <div className="appHeader__actions">
            <Link
                className="unsettedLink actionLink"
                to="/create-event"
            >
                Создать мероприятие
                <AddIcon />
            </Link>
            <Link
                className="unsettedLink actionLink"
                to="/login"
            >
                Войти
                <UserIcon />
            </Link>
        </div>
    </header>
);
