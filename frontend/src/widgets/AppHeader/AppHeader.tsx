import { NavigationLogo } from '@/shared/ui/logo/NavigationLogo';
import { AddIcon } from '@/shared/ui/icons';
import { Link } from 'react-router-dom';
import { ProfileLink } from './ProfileLink';
import './AppHeader.scss';

export const AppHeader = () => (
    <header className="appHeader">
        <NavigationLogo className="appHeader__logo" />
        <div className="appHeader__actions">
            <Link
                className="unsettedLink actionLink"
                to="/add-event"
            >
                Добавить мероприятие
                <AddIcon />
            </Link>
            <ProfileLink />
        </div>
    </header>
);
