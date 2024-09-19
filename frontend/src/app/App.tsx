import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import { RootPage } from './RootPage';
import { EventsPage } from '@/pages/events/EventsPage';
import { EventPage } from '@/pages/event/EventPage';
import { AuthPage } from '@/pages/auth/AuthPage';
import { LogInForm } from '@/features/auth/ui/LogInForm';
import { SignUpForm } from '@/features/auth/ui/SignUpForm';
import { EventFormPage } from '@/pages/add-event/EventFormPage';
import { reatomContext } from '@reatom/npm-react';
import { ctx } from '@/shared/reatom/context';
import './App.scss';

function App() {
    return (
        <reatomContext.Provider value={ctx}>
            <Router>
                <Routes>
                    <Route
                        path="/"
                        element={<RootPage />}
                    >
                        <Route
                            index
                            element={<EventsPage />}
                        />
                        <Route
                            path="/events/:eventId"
                            element={<EventPage />}
                        />
                        <Route
                            path="/add-event"
                            element={<EventFormPage />}
                        />
                    </Route>
                    <Route element={<AuthPage />}>
                        <Route
                            path="/login"
                            element={<LogInForm />}
                        />
                        <Route
                            path="signup"
                            element={<SignUpForm />}
                        />
                    </Route>
                </Routes>
            </Router>
        </reatomContext.Provider>
    );
}

export default App;
