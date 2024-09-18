import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import { RootPage } from './RootPage';
import './App.scss';
import { EventsPage } from '@/pages/events/EventsPage';

function App() {
    return (
        <>
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
                    </Route>
                </Routes>
            </Router>
        </>
    );
}

export default App;
