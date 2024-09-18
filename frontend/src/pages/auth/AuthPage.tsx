import { NavLink as Link, Outlet } from 'react-router-dom';
import clsx from 'clsx';
import { NavigationLogo } from '@/shared/ui/logo/NavigationLogo';
import './AuthPage.scss';
import { ExternalAuthBar } from '@/widgets/ExternalAuthBar/ExternalAuthBar';

const getTabClass = ({ isActive }: { isActive: boolean }) => {
    const tabClass = 'authPage__tab';

    return clsx(tabClass, 'unsettedLink', isActive && `${tabClass}_active`);
};

export const AuthPage = () => {
    return (
        <main className="authPage">
            <div className="authPage__form">
                <NavigationLogo className="authPage__logo" />
                <div className="authPage__tabs">
                    <Link
                        className={getTabClass}
                        to="/login"
                    >
                        Вход
                    </Link>
                    <Link
                        className={getTabClass}
                        to="/signup"
                    >
                        Регистрация
                    </Link>
                </div>
                <Outlet />
                <p className="authPage__externAuthLabel">Войти с помощью:</p>
                <ExternalAuthBar />
            </div>
        </main>
    );
};
