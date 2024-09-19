import { AppHeader } from '@/widgets/AppHeader/AppHeader';
import { ReactNode } from 'react';
import { Outlet } from 'react-router-dom';

type RootPageProps = {
    children?: ReactNode;
};

export const RootPage = ({ children = <Outlet /> }: RootPageProps) => {
    return (
        <>
            <AppHeader />
            {children}
            <footer />
        </>
    );
};
